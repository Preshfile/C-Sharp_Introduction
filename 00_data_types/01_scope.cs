//Consider the given code snippet. Identify and comment out the line that causes an error. Explain why the error occurs 


int test = 20;
{
    Console.WriteLine(test);
    //Console.WriteLine(send); // This line throws an error because "send" is out of scope
                              // Explanation: The variable "send" is declared inside the innermost block,
                              // so it is only accessible within that block and any nested blocks within it.
                              // Therefore, trying to access it outside of its scope results in an error.


    {
        //Console.WriteLine(send); // This line throws an error because "send" is still out of scope
                                  // Explanation: The variable "send" is declared in the inner block,
                                  // so it is only accessible within that block. Trying to access it
                                  // outside of that block or in any nested blocks results in an error.

        int send = 100;
        {
            Console.WriteLine(send);
            Console.WriteLine(test); // "test" is accessible here...
                                     // because it is declared in the outermost block,
                                     // and accessible within all the nested blocks. Therefore, the
                                     // The "test" call is therefore within the scope of the variable
                                     // and does not cause an error.
        }
    }
}
