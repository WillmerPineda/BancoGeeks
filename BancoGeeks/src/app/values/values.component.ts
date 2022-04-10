import { Component, OnInit } from '@angular/core';
import { ServiciAPIBancoGeeks } from "../Servicios/ServicioBancoGeeks.service";
import { ObjetoRespuesta } from "../Objetos/ObjetoValues";
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-values',
  templateUrl: './values.component.html',
  styleUrls: ['./values.component.css']
})
export class ValuesComponent implements OnInit {

  Resultado: number = 0;
  Errror: boolean = false;
  MensajeError:string="";
  Busqueda:boolean=false;
  PerteneceSecuencia:boolean=false;
  Primero: number = 0;
  Segundo: number = 0;
  valDias: string = "";
  value: ObjetoRespuesta = new ObjetoRespuesta;
  regexnumeros: string = "^[+-]?\\d+(\\.\\d+)?$";
  FormSumar: FormGroup = this.formBuilder.group({
    TxtPrimerNumero: ['', [Validators.required, Validators.pattern(this.regexnumeros), Validators.min(1), Validators.minLength(1)]],
    TxtSegundoNumero: ['', [Validators.required, Validators.pattern(this.regexnumeros), Validators.min(1), Validators.minLength(1)]],
  });


  constructor(
    private ServiciAPIBancoGeeks: ServiciAPIBancoGeeks,
    private SpinnerService: NgxSpinnerService,
    private formBuilder: FormBuilder) { }

  ngOnInit(): void {
  }

  SumarNumeros() {
    this.SpinnerService.show();
    if (this.FormSumar.valid) {
      this.ServiciAPIBancoGeeks.Sumar(this.FormSumar.get('TxtPrimerNumero').value,this.FormSumar.get('TxtSegundoNumero').value).then(async (Response: ObjetoRespuesta) => {
        this.Resultado = Response.Resultado;
        this.Errror=Response.Error;
        this.MensajeError=Response.MensajeError;
        this.PerteneceSecuencia=Response.PerteneceSecuencia;
        this.value = Response;
        this.Busqueda=true;
        this.SpinnerService.hide();
      });
    }
  }
}
