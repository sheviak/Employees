import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { InsertPosition } from 'src/app/models/insertPosition';

@Injectable({
    providedIn: 'root'
  })
  
export class PositionService {

    private apiUrl: string = environment.apiUrl;

    constructor(
        private http: HttpClient
    ){}

    insertPosition(position: InsertPosition){
        alert(this.apiUrl);
    }

    getPositions(){
        return this.http.get(`${this.apiUrl}/position`);
    }
}