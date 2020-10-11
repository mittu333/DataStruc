using System;
namespace DataStruc.LinkedList
{
    //This class is used to create link list structure
    public class LinkedList
    {
        //start of the linked list chain
        Node head = null;
        public void AddLast(object data)
        {
            if(head == null)
            {
                Node newItem = new Node();
                newItem.data = data;
                head = newItem;
                head.next = null;
            }
            else
            {
                //loop find the last node and add to it
                Node current = head;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = newItem;
            }
        }
        public void AddFirst(object data)
        {

        }
        public void ReadAll()
        {

        }
    }
}
