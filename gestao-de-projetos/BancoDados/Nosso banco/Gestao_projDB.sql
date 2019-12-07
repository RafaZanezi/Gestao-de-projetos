CREATE TABLE Usuario (
ID_usuario SERIAL PRIMARY KEY,
Nome varchar(60) NOT NULL,
Senha varchar(15) NOT NULL
);

CREATE TABLE Projeto (
ID_projeto SERIAL PRIMARY KEY,
Nome varchar(60) NOT NULL,
DS_Link_Repositorio varchar(90) NOT NULL,
DT_fim DATE NOT NULL,
DT_Inicio DATE NOT NULL,
TP_visibilidade varchar(2),
Descricao varchar(80)
);

CREATE TABLE UsuarioProj(
ID_UP INT NOT NULL,
ID_usuario INT NOT NULL,
ID_projeto INT NOT NULL,
	
CONSTRAINT UsuUPID FOREIGN KEY (ID_usuario) REFERENCES Usuario (ID_usuario),

CONSTRAINT ProjUPID FOREIGN KEY (ID_projeto) REFERENCES Projeto (ID_projeto)

);

CREATE TABLE Tarefa(

Nome_tarefa Varchar(25) NOT NULL,
ID_usuario INT NOT NULL,
ID_projeto INT NOT NULL,
Tempo_estimado time NOT NULL,
Cod_tarefa SERIAL NOT NULL,
CONSTRAINT UsuUPID FOREIGN KEY (ID_usuario) REFERENCES Usuario (ID_usuario),

CONSTRAINT ProjUPID FOREIGN KEY (ID_projeto) REFERENCES Projeto (ID_projeto)

)

-- Altera tamanho da coluna de descrição
ALTER TABLE public.projeto
    ADD COLUMN descricao character varying(250) COLLATE pg_catalog."default";

-- Adiciona coluna do nome_orientador
ALTER TABLE public.projeto
    ADD COLUMN nome_orientador character varying(60);
	
	
-- Remover coluna de tempo estimado
ALTER TABLE public.tarefa
    ADD COLUMN cod_tarefa integer NOT NULL DEFAULT nextval('tarefa_cod_tarefa_seq'::regclass);
	
-- Altera tipo da coluna de tempo estimado para double
ALTER TABLE public.tarefa
    ADD COLUMN tempo_estimado double precision;
	
-- Altera tamanho do nome da tarefa
ALTER TABLE public.tarefa
    ALTER COLUMN nome_tarefa TYPE character varying (50) COLLATE pg_catalog."default";

-- Adiciona coluna de status da tarefa 
ALTER TABLE public.tarefa
    ADD COLUMN status character varying(4);	
	
	