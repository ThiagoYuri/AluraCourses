//export interface Root {
 //   transferencias: Transferencia[]
//}
  
export interface Transferencia {
    id?: number |string
    valor: number
    destino: number|string
    data?: string
}
  