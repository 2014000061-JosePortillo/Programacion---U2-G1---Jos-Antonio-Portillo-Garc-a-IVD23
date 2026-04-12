Algoritmo Act3_Lecc7_inciso2_PSeint
	Definir a1, a2, a3 Como Entero
	Escribir "Triangulos"
	Escribir "Ingrese los angulos del triangulo:"
	Leer a1
	Leer a2
	Leer a3
	
	Si a1 = 60 y a2 = 60 y a3 = 60 Entonces
		Escribir "Es un triangulo equilatero"
	FinSi
	Si a1 = a2 y a3 <> a1 o a1 = a3 y a2 <> a1 o a2 = a3 y a1 <> a2 Entonces
		Escribir "El triangulo es isoceles"
	FinSi
	Si a1 <> a2 y a1 <> a3 y a2 <> a3 Entonces
		Escribir "Es un triangulo escaleno "
	FinSi
FinAlgoritmo