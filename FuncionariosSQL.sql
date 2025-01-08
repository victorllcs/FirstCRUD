create database dbFuncionarios /*Cria um banco de dados*/
default character set utf8mb4 /*Serve para indicar as palavras no idioma latim, ou seja, acentos, etc.*/
default collate utf8mb4_general_ci; 

/*Serve para utilizar o banco de dados desejado*/
use dbFuncionarios;

create table if not exists funcionarios(
	id int not null auto_increment primary key,
    nome varchar(100) not null,
    email varchar(100) not null,
    cpf varchar(11) not null,
    endereco varchar(200) not null
)default char set utf8mb4;

select* from funcionarios; /*Seleciona todos os dados cadastrados no banco de dados*/