using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms
{
    class DataStructuresClass
    {
        // DATA STRUCURES
        // Data structure is a storage that is used to store and organize data.  
        // Algorithms are set of instructions executing acceptable amount time 

        // Basically, data structures are divided into two categories:
        // Linear data structure (Stacks, Queues, LinkedList)
        // Non-linear data structure (Trees, Heaps, Graphs)

        // ALGORITHM ANALYSIS
        // 1) Time Complexity
        // 2) Space Complexity

        // ----------TIME COMPLEXITY-----------------------

        // Running time of algorithm is proportional, increases with the size of input.
        // Measuring time complexity : Experimental Analysis or Theoretical Analysis

        // EXPERİMENTAL ANALYSIS
        // Easier than "Theoretical Analysis" but dependent to hardware, operating systems etc.

        // THEORETICAL ANALYSIS
        // Constant ExecutionTime
        // -Declarations
        // -Assignment
        // -Arithmetic Operations
        // -Comparison Statements
        // -Accessing Elements
        // -Calling Functions
        // -Returning Functions

        public void SampleMethodOne(int n)
        {
            //  PIRIMITIVE OPERATİON            FREQUENCY
            //  Declarations                         2
            //  Assignments                          2
            //  Comparison Operations               N+1
            //  Aritmetic Operations                N+N
            //  ==> 5 + 3N

        int total = 0;      
        int i = 1;                    

        while( i < n )        
        {
            total = total + i;
            i = i + 1;
        }
        }

        public void SampleMethodTwo(int n, int m)
        {
            //  PIRIMITIVE OPERATİON               FREQUENCY
            //  Declarations                         2+N
            //  Assignments                          2+N
            //  Comparison Operations                (N+1) + N*(M+1)
            //  Accessing Array                      N*M
            //  Increment Operation                  (N+1)+N*(M+1)
            //  Aritmetic Operations                 N*M
            //  ==> 6 + 6N + 4NM = 6 + 6N + 4N²

            int total = 0;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    //total = total + A[i][j];
                }
            }
        }

        public bool SampleMethodThree(int n)
        {
            //  PIRIMITIVE OPERATION                 FREQUENCY
            //  Declarations (i&j)                        2
            //  Assignments  (i&j)                        2
            //  Comparison Operations (i<j)             logN + 1
            //  Declarations (mid)                      logN
            //  Assignments  (mid)                      logN
            //  Comparison Operations (while)           logN 
            //  Arithetic Operations                    logN
            //  ==> 5 + 5 * logN


            int i = 0;
            int j = n;
            while (i < j)
            {
                int mid = (i + j) / 2;
                //if (A[mid] == 5)
                //    return true;
                //else if (5 < A[mid])
                //    j = mid - 1;
                //else if (5 > A[mid])
                //    i = mid + 1;                
            }
            return false;
        }


        // ASYMPTOTIC ANALYSIS
        // -Analyis using Mathemetical Notations
        // -Depends on order of growth(size of th input)
        // -Run Time is proportionally to size of input

        // f(n) n ==> 1,2,3,4,5.....100....1000,1001
        // f(n) n² + 6n+ 5  ==> f(n) is said to be asymptotically equivalent to n²

        // ASYMPTOTIC NOTATIONS
        // Big-Oh ==> WorstCase(UpperBound)
        // Big-Omega ==> BestCase(LowerBound)
        // Big Theta ==> AvaregeCase(AvaregeBound)

        // FUNCTION GROWTH
        // Constant         ==>         1        ==>         O(1)
        // Logarithm        ==>         logn     ==>         O(logn)
        // Linear           ==>         n        ==>         O(n)
        // n-log-n          ==>         nlog(n)  ==>         O(nlog(n))
        // Quadratic        ==>         n^2      ==>         O(n^2)
        // Cubic            ==>         n^3      ==>         O(n^3)
        // Exponential      ==>         2^n      ==>         O(2^n)


        // ----------SPACE COMPLEXITY-----------------

        // How many bytes consumed during execution

        // Pirimitive Data Types          Bytes
        // Boolean                          1 
        // Byte                             1
        // Char                             2
        // Int                              4
        // Float                            4
        // Long                             8
        // Double                           8

        // Arrays-1D                       Bytes
        // Char[]                           2xn
        // Int[]                            4xn
        // Double[]                         8xn

        public void SampleMethodFour(double n)
        {
            // ==> Total 16 Byte

            int total = 0;      // 4 byte
            int i = 1;          // 4 Byte

            while (i < n)       // 8 Byte
            {
                total = total + i; 
                i = i + 1;
            }
        }

        public void SampleMethodFive(int n, int m)
        {
            // Memory Usage ==> 16 + 4n + 4nm
            // Memory Usage ==> 16 + 4n + n²

            int total = 0; // 4 Bytes

            for (int i = 0; i < n; i++) // 4 Bytes +  4 Bytes 
            {
                for (int j = 0; j < m; j++) // 4 x n Bytes +  4 Bytes
                {
                    //total = total + A[i][j]; // 4 x nm Bytes
                }
            }
        }




    }
}
