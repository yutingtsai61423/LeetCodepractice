#include <iostream>
#include <stdexcept>
#include <vector>

using namespace std;


template<typename T>

class CycleArray {
	vector<T> arr;
	int start;
	int end;
	int count;

	//擴容輔助函數
	void resize(int newSize) {
		vector<T> newArr(newSize);
		for (int i = 0; i < count; i++) {
			//start + i 代表從 start 往後算第 i 個元素
			newArr[i] = arr[(start + i) % arr.size()]
		}
		//把newArr的內部指標搬到arr，newArr會被變成空的
		// //速度快:O(1) 搬移
		arr = move(newArr);
		start = 0;
		end = count;
	}
	
public:
	CycleArray() : CycleArray(1) {}//呼叫無參數的建構式等於呼叫有參數的建構式&值代入1
	//單參數建構函式 → 習慣加 explicit 規定宣告物件要用規定的建構式寫法
	explicit CycleArray(int size) : arr(size), start(0), end(0), count(0) {
	}
	//Mod在數學上規定是正數，會一直加 N 的倍數，直到你得到模 N 的整數的標準代表，也就是至少 0 且小於 N；你得到哪個整數？
	//而程式的 % 是直接除完後拿餘數，所以會有負數
	void addFirst(const T& val) {
		if (isFull()) {
			resize(arr.size() * 2);
		}
		//start是閉區間，賦值再左移
		start = (start - 1 + arr.size()) % arr.size();
		arr[start] = val;
		count++;
	}

	void removeFirst(){
		if (isEmpty()) {
			return;
		}
		arr[start] = T();
		start = (start + 1) % arr.size();
		count--;

		//如果數量減少到原本的1/4，把數組長度減半
		if (count > 0 && count == arr.size() / 4) {
			resize(arr.size() / 2);
		}
	}

	void removeLast() {
		if (isEmpty()) {
			return;
		}
		//end是開區間不包含端點 所以先左移再賦值
		end = (end - 1 + arr.size()) % arr.size();
		arr[end] = T();
		count--;
		//如果數量減少到原本的1/4，把數組長度減半
		if (count > 0 && count == arr.size() / 4) {
			resize(arr.size() / 2);
		}
	}

	T getFirst() const {
		if (isEmpty()) {
			return;
		}
		return arr[start];
	}

	T getLast() const {
		if (isEmpty()) {
			return;
		}

		return arr[(end - 1 + arr.size()) % arr.size()];
	}

	bool isFull() const {
		return count == arr.size();
	}

	int size() const {
		return count;
	}

	bool isEmpty() const {
		return count == 0;
	}


};
