import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators} from '@angular/forms';
import { InsertEmployee } from 'src/app/models/insertEmployee';
import { EmployeeService } from 'src/app/services/employee.service';
import { Employee } from 'src/app/models/employee';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  
  positionForm : FormGroup;
  employeeForm : FormGroup;

  private pageSize: number = 10;
  pageNumber: number = 1;
  data: Array<Employee> = [];

  constructor(private es: EmployeeService) {

    this.positionForm = new FormGroup({
        "position": new FormControl("", [Validators.required]),
    });

  }


  ngOnInit(): void {
    this.es.getEmployee(this.pageNumber, this.pageSize)
      .subscribe(
        (data: Employee[]) => {
            this.data = data;
        },
        error => { console.log(error); }
    );
  }

  positionFormSubmit(){
    
  }
}
