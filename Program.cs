﻿namespace LongestPalindromicSubsequence
{
    internal class Program
    {
        public class LongestPalindromicSubsequence
        {
            public int LongestPalindromeSubseq(string s)
            {
                int n = s.Length;
                int[,] dp = new int[n, n];
                for (int i = n - 1; i >= 0; --i)
                {
                    dp[i, i] = 1;
                    for (int j = i + 1; j < n; ++j)
                    {
                        if (s[i] == s[j])
                        {
                            dp[i, j] = 2 + dp[i + 1, j - 1];
                        }
                        else
                        {
                            dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j - 1]);
                        }
                    }
                }
                return dp[0, n - 1];
            }
        }
        static void Main(string[] args)
        {
            LongestPalindromicSubsequence longestPalindromicSubsequence = new();
            Console.WriteLine(longestPalindromicSubsequence.LongestPalindromeSubseq("bbbab"));
            Console.WriteLine(longestPalindromicSubsequence.LongestPalindromeSubseq("cbbd"));
        }
    }
}