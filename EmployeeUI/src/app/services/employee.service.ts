import { HttpClient } from '@angular/common/http';
import { InsertEmployee } from 'src/app/models/insertEmployee';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { Employee } from 'src/app/models/employee';

@Injectable({
    providedIn: 'root'
  })
  
export class EmployeeService {

    private apiUrl: string = environment.apiUrl;

    constructor(
        private http: HttpClient
    ){}

    insertEmployee(employee: InsertEmployee){
        alert(this.apiUrl);
    }

    getEmployee(pageNumber: number, pageSize: number){
        return this.http.get(`${this.apiUrl}/employee/${pageNumber}/${pageSize}`);
    }
}