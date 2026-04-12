Algoritmo Act3_Lecc7_inciso1_PSeint
	Definir dia, mes Como Entero
	Escribir "Estacion del año"
	Escribir "Ingrese el dia:"
	Leer dia
	Escribir "Ingrese el mes:"
	Leer mes
	
	Si dia <= 21 y mes >= 3 y mes <= 6 Entonces
		Escribir "Primavera"
	FinSi
	Si dia <= 22 y mes >= 6 y mes <= 9 Entonces
		Escribir "Verano"
	FinSi
	Si dia <= 23 y mes >= 9 y mes <= 12 Entonces
		Escribir "Otoño"
	FinSi
	Si dia <= 22 y mes = 12 y mes >= 1 Entonces
		Escribir "Invierno"
	FinSi
FinAlgoritmo