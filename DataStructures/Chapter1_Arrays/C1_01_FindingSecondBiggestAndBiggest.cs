public class C1_01_FindingSecondBiggestAndBiggest
{
    private int[] inputArray=new int[]{};
    private int size=0;

    public int FindBiggestIndexByPosition(int[] input, int position)
    {
        if(input.Length==0) return -1;//Return -1 when there are no elements in given input array
        if(input.Length==1) return 0;//When there is only one element, then it would be biggest.

        this.inputArray = input;
        this.size = input.Length;

        //If user wants Third biggest, then we first find all 3 biggest elements and pick the last.
        var bigNumbers = new int[position];
        for(int i=0;i<bigNumbers.Length;i++)
            bigNumbers[i] = input[0]; //initialize array with first element of input.

        for(int i=1; i<size ;i++)
        {
            for(int j=0; j<bigNumbers.Length ;j++)
            {
                if(inputArray[i] > bigNumbers[j])
                {
                    SwapToRight(bigNumbers, i);
                    bigNumbers[j] = inputArray[i];
                    break;
                }
                else
            }
        }

        
        return bigNumbers[position]; //change this later
    }

    public void SwapToRight(int[] array, int indexLimit)
    {
        for(int i=array.Length-1; i>indexLimit; i--)
            array[i]=array[i-1];
    }
}