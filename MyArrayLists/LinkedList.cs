using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
    public class LinkedList
    {
        private Node _root;
        private Node _tail;
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                return crnt.Value;
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Node crnt = _root;
                for (int i = 1; i <= index ; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Value = value;
            }
        }
        public int Length { 
            get
            {
                int count = 0; ;
                Node crnt = _root;
                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }
                return count;
            } 
            private set
            {

            } }
        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }
        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }
        public LinkedList(int[] array)
        {
            if (array.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(array[0]);
                Node crnt = _root;
                _tail = crnt;
                for (int i = 1; i < array.Length; i++)
                {
                    crnt.Next = new Node(array[i]);
                    crnt = crnt.Next;
                    _tail = crnt;
                }
            }
        }
        public void Add(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }
        public void AddFirst(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root = new Node(value);
                _root.Next = crnt;
            }
        }
        public void AddByIndex( int index, int num)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (_root == null)
            {
                _root = new Node(num);
                _tail = _root;
            }
            else
            {
                if (index == 0)
                {
                    AddFirst(num);
                }
                else
                {
                    Node prevNode = GetNode(index - 1);
                    Node newNode = new Node(num);
                    Node nextNode = prevNode.Next;
                    prevNode.Next = newNode;
                    newNode.Next = nextNode;
                }
            }
        }
        public void DeleteLast()
        {
            if (_tail is null)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length == 1)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node prevLastNode = GetNode(Length - 2);
                prevLastNode.Next = null;
                _tail = prevLastNode;
            }
        }
        public void DeleteFirst(int index = 0)
        {
            if (_tail is null)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length == 1)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root=_root.Next;
            }
        }
        public void DeleteByIndex(int index)

        {
            if (_tail is null)
            {
                throw new Exception("List have nothing to delete");
            }
            if (index == 0)
            {
                DeleteFirst(index);
            }
            else
            {
                Node prevNode = GetNode(index - 1);
                Node nextNode = GetNode(index + 1);
                prevNode.Next = nextNode;
            }
        }
        public void DeleteRangeEnd(int range)
        {
            if(range >= Length)
            {
                _root = null;
                _tail = null;

            }
            if(Length == 0)
            {
                throw new Exception("List have nothing to delete");
            }
            else
            {
                Node crntNode = GetNode(Length - 1 - range);
                _tail = crntNode;
                _tail.Next = null;
            }
        }
        public void DeleteRangeHead(int range)
        {
            if (range >= Length)
            {
                _root = null;
                _tail = null;
            }
            if (Length == 0)
            {
                throw new Exception("List have nothing to delete");
            }
            Node tmp = _root;
            for (int i = 1; i <= range; i++)
            {
                tmp = _root.Next;
                _root = tmp;
            }
        }
        public void DeleteRangeByIndex(int range, int index)
        {
            if (range >= Length)
            {
                _root = null;
                _tail = null;
            }
            if (Length == 0)
            {
                throw new Exception("List have nothing to delete");
            }
            if (index == 0)
            {
                DeleteRangeHead(range);
            }
            else
            {
                Node preNode = GetNode(index - 1);
                Node nextRangeNode = GetNode(index + range);
                preNode.Next = nextRangeNode;
            }
        }
        public int FindIndex(int index)
        {

            Node crnt = GetNode(index);
            return crnt.Value;
        }
        public int FindIndexByValue(int value)
        {
            if(Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int index = -1;
            Node crnt = _root;
            for (int i = 0; crnt != null; i++)
            {
                if(crnt.Value == value)
                {
                    index = i;
                    break;
                }
                crnt = crnt.Next;
            }
            return index;
        }
        public void ChangeValueByIndex(int index, int value)
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to change");
            }
            Node crnt = _root;
            for (int i = 0; crnt!= null; i++)
            {
                if(index == i)
                {
                    Node newNode = new Node(value);
                    crnt.Value = newNode.Value;
                }
                crnt = crnt.Next;
            }
        }
        public void Revers()
        {
            if(_tail == null)
            {
                throw new Exception();
            }
            Node crnt = _root;
            Node next ;
            while(crnt.Next != null)
            {
                next = crnt.Next;
                crnt.Next = next.Next;
                next.Next = _root;
                _root = next;
            }
            _tail = crnt;
        }
        public int FindMaxValue()
        {
            Node crnt = _root;
            int maxValue = crnt.Value;
            while(crnt.Next != null)
            {
                crnt = crnt.Next;
                if(crnt.Value > maxValue)
                {
                    maxValue = crnt.Value;
                }
            }
            return maxValue;
        }
        public int FindMinValue()
        {
            Node crnt = _root;
            int minValue = crnt.Value;
            while (crnt.Next != null)
            {
                crnt = crnt.Next;
                if (crnt.Value < minValue)
                {
                    minValue = crnt.Value;
                }
            }
            return minValue;
        }
        public int FindIndexOfMaxValue()
        {
            Node crnt = _root;
            int maxValue = crnt.Value;
            int index = 0;
            int i = 0;
            while (crnt != null)
            {
                if (crnt.Value > maxValue)
                {
                    maxValue = crnt.Value;
                    index = i;
                }
                i++;
                crnt = crnt.Next;
            }
            return index;
        }
        public int FindIndexOfMinValue()
        {
            Node crnt = _root;
            int minValue = crnt.Value;
            int index = 0;
            int i = 0;
            while (crnt != null)
            {
                if (crnt.Value < minValue)
                {
                    minValue = crnt.Value;
                    index = i;
                }
                i++;
                crnt = crnt.Next;
            }
            return index;
        }
        public void SortOrderList()
        {
            for (int i = 0; i < Length-1; i++)
            {
                Node crnt = _root;
                Node next = crnt.Next;
                Node prev = _root;
                int count = 0;

                while(next != null)

                {
                    if(crnt==_root && crnt.Value > next.Value)
                    {
                        crnt.Next = next.Next;
                        _root = next;
                        next.Next = crnt;
                        prev = next;

                        count++;
                    }
                    else if(crnt.Value > next.Value)
                    {
                        crnt.Next = next.Next;
                        prev.Next = next;
                        next.Next = crnt;
                        prev = next;

                        count++;
                    }
                    else
                    {
                        crnt = crnt.Next;
                        count++;

                        if (count > 1)
                        {
                            prev = prev.Next;
                        }
                    }
                    next = crnt.Next;
                }
            }
        }
        public void SortLess()
        {
            for (int i = 0; i < Length-1; i++)
            {
                Node crnt = _root;
                Node next = crnt.Next;
                Node prev = _root;
                int count = 0;

                while (next != null)
                {
                    if (crnt == _root && crnt.Value < next.Value)
                    {
                        crnt.Next = next.Next;
                        _root = next;
                        next.Next = crnt;
                        prev = next;

                        count++;
                    }
                    else if (crnt.Value < next.Value)
                    {
                        crnt.Next = next.Next;
                        prev.Next = next;
                        next.Next = crnt;
                        prev = next;

                        count++;
                    }
                    else
                    {
                        crnt = crnt.Next;
                        count++;
                        if (count > 1)
                        {
                            prev = prev.Next;
                        }
                    }
                    next = crnt.Next;
                }
            }
        }
        public int DeleteFirstAtValue(int value)
        {
            if(_root == null)
            {
                throw new Exception("List have nothing to delete");
            }
            int index = 0;
            Node crnt = _root;
            while (crnt != null)
            {
                if (crnt.Value==value)
                {
                    if (index == 0)
                    {
                        _root = crnt.Next;
                        break;
                    }
                    else
                    {
                        Node prev = GetNode(index - 1);
                        prev.Next = crnt.Next;
                        break;
                    }
                }
                index++;
                crnt = crnt.Next;
            }
            return index;
        }
        public int DeleteAllAtValue(int value)
        {
            if(_root==null)
            {
                throw new Exception("List have nothing to delete");
            }
            int index = 0;
            int count = 0;
            Node crnt = _root;
            while (crnt != null)
            {
                if (crnt.Value == value)
                {
                    DeleteByIndex(index);
                    index--;
                    count++;
                }
                index++; 
                crnt = crnt.Next;
            }
            return count;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }
            Node thisCrnt = _root;
            Node listCrnt = list._root;
            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }
                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }

            return true;
        }
        public override string ToString()
        {
            string str = "[ ";
            Node crnt = _root;
            while (crnt != null)
            {
                str += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            str += "]";

            return str;
        }
        public Node GetNode(int index)
        {
            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }
            return crnt;
        }
    }
}
