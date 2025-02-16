        public int[] ProductExceptSelf(int[] nums)
        {
            int len = nums.Length;
            int[] prefix = new int[len];
            int[] postfix = new int[len];

            int prefixtmp = 1;
            for (int i = 0; i < len; i++)
            {
                prefix[i] = prefixtmp * nums[i];
                prefixtmp = prefix[i];
            }

            int postfixtmp = 1;
            for (int i = len - 1; i >= 0; i--)
            {
                postfix[i] = postfixtmp * nums[i];
                postfixtmp = postfix[i];
            }

            int[] res = new int[len];
            for (int i = 0; i < len; i++)
            {
                int pref = (i - 1 < 0) ? 1 : prefix[i - 1];
                int postf = (i + 1 > len - 1) ? 1 : postfix[i + 1];
                res[i] = pref * postf;
            }


            return res;
        }
