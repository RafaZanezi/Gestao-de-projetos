
CREATE DATABASE bd_lp2;

USE bd_lp2;

CREATE TABLE tb_cliente (
pk_cliente SERIAL PRIMARY KEY,
nome varchar(60) NOT NULL,
cpf varchar(11) NOT NULL,
endereco varchar(255) NOT NULL,
cep varchar(11) NOT NULL
);

select * from tb_cliente;

select count(*) from tb_cliente;

select nome, cpf, endereco, cep from tb_cliente;

INSERT INTO tb_cliente VALUES (DEFAULT, 'Joao Pedro Neves', '11122233300', 'Rua Francisco Couto', '11111222');
INSERT INTO tb_cliente VALUES (DEFAULT, 'Joao Botelho Alves','11122233301', 'Avenida Brasil', '11111223');
INSERT INTO tb_cliente VALUES (DEFAULT, 'Maria da Silva Soares','11122233302', 'Avenida Comendador Aladino Selmi','11111224');


