class Solution
{

    public int finalPositionOfSnake(int n, IList<string> commands)
    {
        int row = 0;
        int column = 0;
        foreach (string command in commands)
        {
            switch (command)
            {
                case "RIGHT":
                    column++;
                    break;
                case "LEFT":
                    column--;
                    break;
                case "UP":
                    row--;
                    break;
                case "DOWN":
                    row++;
                    break;
                default:
                    break;
            }
        }

        return row * n + column;
    }
}
