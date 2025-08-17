#include <iostream>
#include <stdexcept>
#include <vector>
#include <list>



template<typename K, typename V>
class MyChaingingHashMap {
	//拉鍊法
	struct KVNode {
		K key;
		V value;

		KVNode(K key, V val) : key(key), value(std::move(val)) {
		}
	};

	//HashMap底層
	vector<list<KVNode>> table;

	int _size;
	//初始容量
	static constexpr int INIT_CAP = 4;

	//Hash函數 計算key對應的索引
	int hash(K key) {
		//去掉負號 只保留正值
		return (std::hash<K>{}(key) & 0x7fffffff) % table.size();
	}

	void resize(int newCap) {
		newCap = std::max(newCap, 1);
		MyChaingingHashMap<K, V> newMap(newCap);
		for (auto& list : table) {
			for (auto& node : list){
				newMap.put(node.key, node.value);
			}
		}

		this->table = newMap.table;
	}

public:
	MyChaingingHashMap() : MyChaingingHashMap(INIT_CAP) {
	}
	explicit MyChaingingHashMap(int initCapacity){
		_size = 0;
		initCapacity = std::max(initCapacity, 1);
		table.resiz(initCapacity);
	}


    // **** 增/改 ****

// 添加 key -> val 键值对
// 如果键 key 已存在，则将值修改为 val
    void put(K key, V val) {
        auto& list = table[hash(key)];
        // 如果 key 之前存在，则修改对应的 val
        for (auto& node : list) {
            if (node.key == key) {
                node.value = val;
                return;
            }
        }
        // 如果 key 之前不存在，则插入，size 增加
        list.emplace_back(key, val);
        size_++;

        // 如果元素数量超过了负载因子，进行扩容
        if (size_ >= table.size() * 0.75) {
            resize(table.size() * 2);
        }
    }

    // **** 删 ****

    // 删除 key 和对应的 val
    void remove(K key) {
        auto& list = table[hash(key)];
        // 如果 key 存在，则删除，size 减少
        for (auto it = list.begin(); it != list.end(); ++it) {
            if (it->key == key) {
                list.erase(it);
                size_--;

                // 缩容，当负载因子小于 0.125 时，缩容
                if (size_ <= table.size() / 8) {
                    resize(table.size() / 4);
                }
                return;
            }
        }
    }

    // **** 查 ****

    // 返回 key 对应的 val，如果 key 不存在，则返回 nullptr
    V get(K key) {
        const auto& list = table[hash(key)];
        for (const auto& node : list) {
            if (node.key == key) {
                return node.value;
            }
        }
        return nullptr;
    }

    // 返回所有 key
    std::list<K> keys() {
        std::list<K> keys;
        for (const auto& list : table) {
            for (const auto& node : list) {
                keys.push_back(node.key);
            }
        }
        return keys;
    }

    // **** 其他工具函数 ****

    int size() const {
        return size_;
    }
};
