public class MyLinkedList {
    
    // 1. Define the Node class inside
    public class Node {
        public int val;
        public Node next;
        public Node(int val) {
            this.val = val;
            this.next = null;
        }
    }

    private Node head;
    private int size;

    // 2. Initialize with a dummy head and size 0
    public MyLinkedList() {
        head = new Node(0); // Dummy node (doesn't count as a real element)
        size = 0;
    }
    
    public int Get(int index) {
        // If index is out of bounds, return -1
        if (index < 0 || index >= size) return -1;

        Node curr = head.next;
        for (int i = 0; i < index; i++) {
            curr = curr.next;
        }
        return curr.val;
    }
    
    public void AddAtHead(int val) {
        AddAtIndex(0, val); // Head is just index 0!
    }
    
    public void AddAtTail(int val) {
        AddAtIndex(size, val); // Tail is just index equal to size!
    }
    
    public void AddAtIndex(int index, int val) {
        if (index > size) return; // If index is too big, do nothing
        if (index < 0) index = 0;

        // Walk to the node BEFORE the spot we want to insert
        Node prev = head;
        for (int i = 0; i < index; i++) {
            prev = prev.next;
        }

        // Insert the new node
        Node newNode = new Node(val);
        newNode.next = prev.next;
        prev.next = newNode;
        size++; // Don't forget to track that our list got bigger!
    }
    
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= size) return; // Out of bounds check

        // Walk to the node BEFORE the one we want to delete
        Node prev = head;
        for (int i = 0; i < index; i++) {
            prev = prev.next;
        }

        // Skip over the target node to delete it
        prev.next = prev.next.next;
        size--; // Track that our list got smaller!
    }
}


/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */