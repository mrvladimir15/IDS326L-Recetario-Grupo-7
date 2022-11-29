/*

GRUPO 7

    

    integrantes:

     - Juan Ávila - 1100378.

     - Vladimir González  - 1098139.

     - Deivy Jr. Peña - 1099429.

     - Leonel Rodríguez  - 1098665.

     

     

        GRAMÁTICA RECETARIO:

*/

grammar recetaParser;



recetaParser : (receta)+ EOF;



receta : titulo porciones tiempo_preparacion? tiempo_coccion? calorias ingredientes elaboracion;



titulo : RECETA SEP NUM? TEXT ;

porciones : PORCIONES SEP NUM? SEP TEXT ;

tiempo_preparacion : TIEMPO_PREPARACION SEP NUM? SEP TEXT ;

tiempo_coccion : TIEMPO_COCCION SEP NUM? SEP TEXT ;

calorias : CALORIAS SEP NUM? SEP TEXT ;

ingredientes : INGREDIENTES (NUM SEP TEXT COMA?)* ;

elaboracion : ELABORACION (ORD TEXT)* ;




RECETA : '- RECETA:' ;

PORCIONES : '- PORCIONES:';

TIEMPO_PREPARACION : '- TIEMPO PREPARACION:' ;

TIEMPO_COCCION : '- TIEMPO COCCION:' ;

INGREDIENTES : '- INGREDIENTES:' ;

CALORIAS : '- CALORIAS:' ;

ELABORACION : '- ELABORACION:' ;







SEP : ' '+ ;

TEXT : WORD (SEP WORD)* SEP? ;

WORD : [a-zA-Z]+ ;

NUM : [0-9]+ | [0-9]'.'[0-9]+ ;

ORD : NUM')'SEP ;

COMA : ',' ;

/*TAB : '\t' ;*/





SK : '\n' -> skip ;

SK1 : '\r' -> skip ;

SK2 : '\t' -> skip ;