namespace MyArrayLists
{
    public class ArrList
    {
        public int ArrayLength { get; set; }
        private int[] _array;

        public ArrList()
        {
            _array = new int[10];
            ArrayLength = 2;
        }
        public ArrList(int[] array)
        {
            if(array==null || array.Length == 0)
            {
                _array = new int[10];
                ArrayLength=0;
            }
            else
            {
                _array = array;
                ArrayLength = array.Length;
                UpSize();

            }
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > ArrayLength)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index > ArrayLength)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }
        
        public void Add(int num)
        {
            if (ArrayLength >= _array.Length)
            {
                UpSize();
            }
            _array[ArrayLength] = num;
            ArrayLength++;
        }
        public void AddFirst(int num)
        {
            if (ArrayLength+1 >= _array.Length)
            {
                UpSize();
            }
            MoveRight();
            _array[0] = num;
            ArrayLength++;
        }
        public void AddInIndex(int index, int num)
        {
            if (ArrayLength >= _array.Length)
            {
                UpSize();
            }
            MoveRight(index);
            _array[index] = num;
            ArrayLength++;
        }
        public void DeletedEnd()
        {
            if (ArrayLength < 1)
            {
                throw new Exception("удалять нечего");
            }
            ArrayLength--;
        }
        public void DeletedFirst()
        {
            if(ArrayLength < 1)
            {
                throw new Exception("удалять нечего");
            }
            int[] newarr = new int[ArrayLength - 1];
            for (int i = 0; i < ArrayLength-1; i++)
            {
                newarr[i] = _array[i + 1];
            }
            _array = newarr;
            ArrayLength--;
        }
        public void DeletedAtIndex(int index)
        {
            if (ArrayLength < 1)
            {
                throw new Exception("удалять нечего");
            }
            if (index < 0 || index > ArrayLength)
            {
                throw new IndexOutOfRangeException("index");
            }

            int[] newArr = new int[ArrayLength - 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = _array[i];
            }
            for (int i = index; i < ArrayLength-1; i++)
            {
                newArr[i] = _array[i + 1];
            }
            _array = newArr;
            ArrayLength--;

        }
        public void RemovingNelementsFromTheEnd(int num)
        {
            ArrayLength -= num;
        }
        public void RemovingNelementsFromTheHead(int num)
        {
            int[] newarr = new int[ArrayLength-num];
            for (int i = 0; i < ArrayLength-num; i++)
            {
                newarr[i] = _array[i + num];
            }
            _array = newarr;
            ArrayLength-=num;
        }
        public void DeletingByIndexNelements(int index, int count)
        {
            if (index < 0||index>_array.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            if(count < 0)
            {
                throw new ArgumentException("count value");
            }
            int[] newArr = new int[ArrayLength - 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = _array[i];
            }
            for (int i = index; i < ArrayLength - 1 ; i++)
            {
                newArr[i] = _array[i + count];
            }
            _array = newArr;
            ArrayLength -= count; 
        }
        public int FindIndexByFirstElement(int value)
        {
            if (ArrayLength == 0)
            {
                throw new Exception("nothing find");
            }
            int index = -1;
            for (int i = 0; i < ArrayLength; i++)
            {
                if (value == _array[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void ChangeValueByIndex(int index,int value)
        {
            if (ArrayLength == 0)
            {
                throw new Exception("nothing change");
            }
            if (index < 0 || index > _array.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            for (int i = 0; i < ArrayLength; i++)
            {
                if (index == i)
                {
                    _array[i] = value;
                }
            }
        }
        public void ReversArray()
        {
            int[] revArr = new int[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
            {
                int tmp = _array[i];
                revArr[i] = _array[ArrayLength - i-1];
                _array[i] = tmp;
            }
            _array = revArr;
        }
        public int FindMaxValue()
        {
            int maxValue = _array[0];
            for (int i = 0; i < ArrayLength; i++)
            {
                if (_array[i] > maxValue)
                {
                    maxValue = _array[i];
                }
            }
            return maxValue;
        }
        public int FindMinValue()
        {
            int minValue = _array[0];
            for (int i = 0; i < ArrayLength; i++)
            {
                if (_array[i] < minValue)
                {
                    minValue = _array[i];
                }
            }
            return minValue;
        }
        public int FindIndexOfMaxValue()
        {
            int index = 0;
            int maxValue = _array[0];
            for (int i = 0; i < ArrayLength; i++)
            {
                if (_array[i] > maxValue)
                {
                    index = i;
                }
            }
            return index;
        }
        public int FindIndexOfMinValue()
        {
            int index = 0;
            int minValue = _array[0];
            for (int i = 0; i < ArrayLength; i++)
            {
                if (_array[i] < minValue)
                {
                    index = i;
                }
            }
            return index;
        }
        public void SortOrderArray()
        {
            for (int i = 0; i < ArrayLength; i++)
            {
                for (int j = 0; j < ArrayLength-1; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        int tmp = _array[j];
                        _array[j] = this._array[j + 1];
                        _array[j+1] = tmp;
                    }
                }
            }
        }
        public void SortLessArray()
        {
            for (int i = 0; i < ArrayLength; i++)
            {
                for (int j = 0; j < ArrayLength-1; j++)
                {
                    int temp = _array[j];
                    if (_array[j] < _array[j + 1])
                    {
                        for (int k = 0; k < j + 1; k++)
                        {
                            while (j != ArrayLength && _array[j] < _array[j + 1])
                            {
                                _array[j] = _array[j + 1];
                            }
                            _array[j + 1] = temp;
                        }
                    }
                }
            }
        }
        public int DeleteFirstFound(int value)
        {
            if (ArrayLength == 0)
            {
                throw new Exception("Тебе нечего удалять");
            }
            int index = 0; ;
            int[] newArr = new int[ArrayLength - 1];
            for (int i = 0; i < ArrayLength; i++)
            {
                if (value == _array[i])
                {
                    index = i;
                    for(int f = 0; f < index; f++)
                    {
                        newArr[f] = _array[f];
                    }
                    for (int f = index; f < ArrayLength-1; f++)
                    {
                        newArr[f] = _array[f + 1];
                    }
                    break;
                }
            }
            _array = newArr;
            ArrayLength--;
            return index;
            
        }
        public int DeleteOllFound(int value)
        {
            if (ArrayLength == 0)
            {
                throw new Exception("Тебе нечего удалять");
            }
            int count = 0;
            int[] newArr = new int[ArrayLength - 1];
            for (int i = 0; i < ArrayLength; i++)
            {
                if (value == _array[i])
                {
                    count++;
                }
                else
                {
                    newArr[i - count] = _array[i];
                }
            }
            _array = newArr;
            ArrayLength -= count;
            return count;
        }
        public void AddListToEnd(ArrList list)
        {
            if(list is null)
            {
                throw new NullReferenceException();
            }
            else
            {
                for (int i = 0; i <list.ArrayLength; i++)
                {
                    Add(list[i]);
                }
            }
        }
        public void AddListToBeginning(ArrList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }
            if (ArrayLength + list.ArrayLength >= _array.Length)
            {
                UpSize();
            }
            AddList(list);
        }
        public void AddListToIndex(ArrList list, int index)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }
            if (ArrayLength + list.ArrayLength >= _array.Length)
            {
                UpSize();
            }
            if (index < 0 || index > ArrayLength)
            {
                throw new IndexOutOfRangeException();
            }
            AddList(list,index);
        }
        private void AddList(ArrList list, int index = 0)
        {
            int[] tmpArr = new int[_array.Length + list.ArrayLength];

            for (int i = 0; i < index; i++)
            {
                tmpArr[i] = _array[i];
            }
            for (int i = list.ArrayLength + index; i < tmpArr.Length; i++)
            {
                tmpArr[i] = _array[i - list.ArrayLength];
            }
            for (int i = index; i < list.ArrayLength + index; i++)
            {
                tmpArr[i] = list[i - index];
            }
            ArrayLength += list.ArrayLength;
            _array = tmpArr;
        }
        public void Write()
        {
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine($"{_array[i]}");
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string s = " ";
            for (int i = 0; i < ArrayLength; i++)
            {
                s += $"{_array[i]}";
            }
            return s;

        }
        public override bool Equals(object? obj)
        {
            if ((obj == null) || !(obj is ArrList))
            {
                return false;
            }
            ArrList list =(ArrList)obj;
            if (list.ArrayLength != this.ArrayLength)
            {
                return false;
            }
            for (int i = 0; i < this.ArrayLength; i++)
            {
                if (list[i] != this[i])
                {
                    return false;
                }
            }
            return true;
        }
        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d);
            int[] newArray = new int[newLength];
            for(int i = 0; i < _array.Length; i++)
            {
                newArray[i]=_array[i];
            }
            _array = newArray;
        }
        private void MoveRight(int index = 0)
        {

            int[] newArr = new int[ArrayLength + 1];
            for( int i = 0; i < index; i++)
            {
                newArr[i] = _array[i];
            }
            for (int i = index; i < ArrayLength; i++)
            {
                newArr[i + 1] = _array[i];
            }
            _array = newArr;
        }
    }
}