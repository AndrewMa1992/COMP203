public class Node{
    private Node next;
    private int value;

    public Node(){
        
    }
    public Node(int data){
        this.value = data;
        this.next = null;
    }
    public Node Next { get => next; set => this.next = value; }
    public int Value { get => value; set => this.value = value; }
}