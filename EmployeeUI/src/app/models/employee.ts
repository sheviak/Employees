import { EmployeePosition } from 'src/app/models/employeePosition';

export class Employee {
    firstName: string;
    lastName: string;
    employeePositions: Array<EmployeePosition>;
}