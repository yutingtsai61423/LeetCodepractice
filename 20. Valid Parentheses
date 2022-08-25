class Solution {
	public static boolean isValid(String s) {
		String question = s;
		if (s.length() % 2 != 0) {
			return false;
		}
		Stack<Character> stack = new Stack<Character>();
		loop: for (char c : question.toCharArray()) {
			System.out.println("c=" + c);
			if (c == '{' || c == '[' || c == '(') {
				stack.push(c);
				System.out.println("stack= " + stack);
			} else {
				if(stack.size() == 0) {
					return false;
				}
				char compare = stack.pop();
				switch (c) {
				case ']':
					System.out.println("compaere=" + compare);
					if (compare == '[') {
						break;
					}
					System.out.println(false);
					return false;
				case '}':
					System.out.println("compaere=" + compare);
					if (compare == '{') {
						break;
					}
					System.out.println(false);
					return false;
				case ')':
					if (compare == '(') {
						break;
					}
					System.out.println(false);
					return false;
				default:
					System.out.println(false);
					System.out.println("compaere=" + compare);
					return false;
				}
			}
		}
		if (stack.size() != 0) {
			return false;
		} else {
			return true;
		}

	}
}
