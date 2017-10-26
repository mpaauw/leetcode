/*
// Employee info
class Employee {
    // It's the unique id of each node;
    // unique id of this employee
    public int id;
    // the importance value of this employee
    public int importance;
    // the id of direct subordinates
    public List<Integer> subordinates;
};
*/
class Solution {
    public int getImportance(List<Employee> employees, int id) {
        int sum = 0;
        // edge cases:
        if(employees == null) {
            return sum;
        }
        else if(employees.size() < 1) {
            return sum;
        }
        
        HashMap<Integer,Integer> employeeMap = new HashMap<Integer,Integer>(); // store a hash map of employee id's and their indexes within the list for quick lookup

        // build map of employees:
        Employee employee = null;
        for(int i = 0; i < employees.size(); i++) {
            Employee current = employees.get(i);
            if(!employeeMap.containsKey(current.id)) { // if employee is not already present within the hash map, store data
                employeeMap.put(current.id, i);
            }
        }

        // find data on employee in question:
        if(employeeMap.containsKey(id)) {
            Employee primaryEmployee = employees.get(employeeMap.get(id));
            Stack<Employee> stack = new Stack<Employee>(); // use a stack to keep track of indirect employee-subordinate relationships
            stack.push(primaryEmployee);
            while(!stack.isEmpty()) {
                Employee current = stack.pop();
                sum += current.importance;
                for(Integer subId : current.subordinates) {
                    Employee drone = employees.get(employeeMap.get(subId));
                    stack.push(drone);
                }
            }
        }

        return sum;
    }
}