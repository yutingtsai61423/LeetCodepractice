class MyLinkedList {
private:
    struct Node
    {
        int val;
        Node* next;
        Node(int value) : val(value), next(nullptr) {}
    };

    Node* dummyHead;
    Node* tail = nullptr;
    int _size = 0;
    //Node* dummyHead = new Node(0);

public:

    MyLinkedList() {
        dummyHead = new Node(0);
        tail = dummyHead;
        _size = 0;
    }

    ~MyLinkedList() {
        Node* current = dummyHead;
        while (current != nullptr) {
            Node* next = current->next;
            delete current;
            current = next;
        }
    }

    int get(int index) {
        if (index >= _size) return -1;
        Node* cur = dummyHead;
        for (int i = 0; i <= index; i++) {
            cur = cur->next;
        }
        return cur->val;
    }

    void addAtHead(int val) {
        //new一個節點 放在 dummyHead 之後
        Node* newNode = new Node(val);
        newNode->next = dummyHead->next;
        dummyHead->next = newNode;
        if (_size == 0)
        {
            tail = newNode;
        }
        _size++;
    }

    void addAtTail(int val) {
        Node* newTail = new Node(val);
        tail->next = newTail;
        tail = newTail;
        _size++;
    }

    void addAtIndex(int index, int val) {
        if (index == _size) {
            addAtTail(val);
        }
        else if (index > _size || index < 0) {
            return;
        }
        else {
            //拿到前一個節點
            Node* cur = dummyHead;
            for (int i = 0; i < index ; i++){
                cur = cur->next;
            }
            Node* newNode = new Node(val);
            newNode->next = cur->next;
            cur->next = newNode;
            _size++;
        }
    }

    void deleteAtIndex(int index) {
        Node* toBeDelete = nullptr;
        if (_size <= 0 || index >= _size) return;
        //如果是刪第一個節點
        if (index == 0) {
            Node* toBeDelete = dummyHead->next;
            dummyHead->next = toBeDelete->next;
            if (_size == 1)
                tail = dummyHead;
        }
        //如果刪最後一個節點
        else if(index == (_size - 1)) {
            Node* prev = dummyHead;
            while (prev->next != tail){
                prev = prev->next;
            }
            delete tail;
            tail = prev;
            prev->next = nullptr;
        }
        else {
            //拿到前一個節點和被刪的節點
            Node* prev = dummyHead;
            for (int i = 0; i < index; i++) {
                prev = prev->next;
            }
            toBeDelete = prev->next;
            prev->next = toBeDelete->next;

        }
        delete toBeDelete;
        _size--;
    }
};
