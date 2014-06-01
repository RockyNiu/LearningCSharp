using System;
using System.IO;

namespace AlgorithmsInCSharpTest
{
    /*
     * You are given two sequences. Write a program to determine the longest common subsequence between the two strings (each string can have a maximum length of 50 characters). NOTE: This subsequence need not be contiguous. The input file may contain empty lines, these need to be ignored.

    * INPUT SAMPLE:

    * The first argument will be a path to a filename that contains two strings per line, semicolon delimited. You can assume that there is only one unique subsequence per test case. E.g.

    * XMJYAUZ;MZJAWXU
    * OUTPUT SAMPLE:

    * The longest common subsequence. Ensure that there are no trailing empty spaces on each line you print. E.g.

    * MJAU

     */

    class LongestCommonSubsequence
    {
        static void Main(string[] args)
        {

            StreamReader inputStreamReader = null;
            LongestCommonSubsequenceSolution solution = new LongestCommonSubsequenceSolution();
            String readLine;
            int count = 0;
            String[] words;
            String outputLine;

            try
            {

                inputStreamReader = new StreamReader(@args[0]);

                // read each line of file
                while ((readLine = inputStreamReader.ReadLine()) != null)
                {
                    count++;

                    // for empty line
                    if ((readLine = readLine.Trim()) == "")
                        continue;

                    words = readLine.Split(';');

                    // if there is not two words in a line
                    if (words.Length != 2)
                    {
                        Console.WriteLine("wrong words in line {0}", count);
                        continue;
                    }

                    outputLine = solution.LCS(words[0], words[1]).Trim();
                    System.Console.WriteLine(outputLine);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
            }
            catch (IOException e)
            {
                // Extract some information from this exception, and then 
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}.", e.Source);
                else
                    Console.WriteLine("IOException happened.");
            }
            finally
            {
                inputStreamReader.Close();
            }
        }
    }



    /*
     * LCS solutin for each line;
     */
    public class LongestCommonSubsequenceSolution
    {
        public String LCS(String str1, String str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int[,] dp = new int[len1 + 1, len2 + 1];
            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        dp[i + 1, j + 1] = dp[i, j] + 1;
                    }
                    else
                    {
                        dp[i + 1, j + 1] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
                    }
                }
            }

            String output = "";
            for (int i = len1, j = len2; i > 0 && j > 0; )
            {
                if (dp[i, j] == dp[i - 1, j])
                {
                    i--;
                }
                else if (dp[i, j] == dp[i, j - 1])
                {
                    j--;
                }
                else
                {
                    System.Diagnostics.Debug.Assert(str1[i - 1] == str2[j - 1]);
                    output = str1[i - 1] + output;
                    i--;
                    j--;
                }
            }

            return output;
        }
    }
}

