import {Injectable} from "@angular/core";
import {Observable, observable} from "rxjs";
import {HttpClient} from "@angular/common/http";
import {ObjetoRespuesta} from "../Objetos/ObjetoValues";

@Injectable()

export class ServiciAPIBancoGeeks
{
   private URLApi="https://localhost:44365/api/";

   constructor(public http:HttpClient){}

   private get(url: string) {
      return this.http.get(url);
  }

   public Sumar(PrimerValor:number,SegundoValor:number):Promise<ObjetoRespuesta>
   {
    return new Promise((resolve, reject) => {
        try {
          this.get(this.URLApi+"/SumarValores/Suma?PrimerValor="+PrimerValor+"&SegundoValor="+SegundoValor).subscribe((response: any) => {
            if (!response.Error) {
              resolve(response);
            } else {
              reject(response);
            }
          },
            (exception) => {
            }
          );
        }
        catch (ex) {
          reject(ex);
        }
      });
   }
}