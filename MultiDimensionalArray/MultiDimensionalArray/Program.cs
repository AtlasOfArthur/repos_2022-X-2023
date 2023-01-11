{
	public static void Main()
	{
		int[,] nums = new int[3, 3]
		{
			{ 1,2,3 },
			{ 4,5,6 },
			{ 7,8,9 }
		};

		for (int y = 0; y < nums.GetLength(0); y++)
		{
			for (int x = 0; x < nums.GetLength(1); x++)
			{
				Console.Write(nums[y, x] + " ");
			}
			Console.WriteLine();
		}
	}
}