﻿using pilaresPOO.Classes.Aprendizagem;
using PilaresPOO.Classes.Aprendizagem;
//heranca
//abstracao
//encapsulamento
//polimorfismo



//Pessoa joao = new Pessoa();
//joao.Nome = "João";

//Console.WriteLine($"{joao.Nome} nasceu com {joao.idade} anos");

//DADOS DO PROFESSOR
//Professor sam = new Professor(123321);
//sam.Nome = "Samanta";
//sam.idade = 22;

//DADOS DO ALUNO
//Aluno isaacBorges = new Aluno();

//isaacBorges.Nome = "isaac borges";
//isaacBorges.matricula = 1234987;
//isaacBorges.curso = "Dev";
//isaacBorges.media = 7.9f;
//isaacBorges.idade = 17;
//isaacBorges.cpf = "50526653850";
//isaacBorges.peso = 85;
//isaacBorges.altura = 1.80f;

//EXIBICAO DE DADOS
//Console.WriteLine($"Curso: {isaacBorges.curso}");
//Console.WriteLine($"Professor: {sam.Nome}");
//Console.WriteLine($"Identificacao do professor: {sam.NIF}");


//Console.WriteLine($"Aluno: {isaacBorges.Nome}");
//Console.WriteLine($"Idade: {isaacBorges.idade}");
//Console.WriteLine($"Matricula: {isaacBorges.matricula}");
//Console.WriteLine($"Media: {isaacBorges.media}");


Carro Porsche = new Carro();

Porsche.Marca = "Porsche";
Porsche.Modelo = "2018";
Porsche.Cor = "Azul";
Porsche.Potencia = 700f;
Porsche.qtdPassageiros = 5;
Porsche.qtdPortas = 4;



Console.WriteLine($"Marca : {Porsche.Marca}");
Console.WriteLine($"Modelo : {Porsche.Modelo}");
Console.WriteLine($"Cor : {Porsche.Cor}");
Console.WriteLine($"Potencia : {Porsche.Potencia}");
Console.WriteLine($"Quantidade de passageiros : {Porsche.qtdPassageiros}");
Console.WriteLine($"Quantidade de portas: {Porsche.qtdPortas}");


Console.WriteLine($"");

Porsche.Ligar();
Porsche.Desligar();
Porsche.Buzinar();

Console.WriteLine($"------------------------------------------------------------------------");

Aviao aeronave = new Aviao();

aeronave.Marca = "Gol";
aeronave.Modelo = "2010";
aeronave.Cor = "branco";
aeronave.Potencia = 50000f;
aeronave.qtdPassageiros = 140;
aeronave.qtdPortas= 6;

Console.WriteLine($"Marca : {aeronave.Marca}");
Console.WriteLine($"Modelo : {aeronave.Modelo}");
Console.WriteLine($"Cor : {aeronave.Cor}");
Console.WriteLine($"Potencia : {aeronave.Potencia}");
Console.WriteLine($"Quantidade de passageiros : {aeronave.qtdPassageiros}");
Console.WriteLine($"Quantidade de Portas: {aeronave.qtdPortas}");


Console.WriteLine($"");

Porsche.Ligar();
Porsche.Desligar();
Porsche.Buzinar();


Console.WriteLine($"-------------------------------------------------------------------");

Moto motinha = new Moto();

motinha.Marca = "Honda";
motinha.Modelo = "2018";
motinha.Cor = "vermelho";
motinha.Potencia = 1200f;
motinha.qtdPassageiros = 2;

Console.WriteLine($"Marca : {motinha.Marca}");
Console.WriteLine($"Modelo : {motinha.Modelo}");
Console.WriteLine($"Cor : {motinha.Cor}");
Console.WriteLine($"Potencia : {motinha.Potencia}");
Console.WriteLine($"Quantidade de passageiros : {motinha.qtdPassageiros}");

Console.WriteLine($"");

motinha.Ligar();
motinha.Desligar();
motinha.Buzinar();

