class Solution {
    public boolean isValid(String s) {
        Map<Character, Character> map =  Map.of(
            ')', '(',
            '}', '{',
            ']', '['
        );
        Deque<Character> stack = new ArrayDeque<>();
        for(var c: s.toCharArray()){
            if(map.containsKey(c)){
                
                var opening = map.get(c);

                if(stack.size() > 0 && stack.peek().equals(opening)){
                    stack.pop();
                } else{
                    return false;
                }
            } else {
                stack.push(c);
            }
        }

        return stack.size() == 0;
    }
}
