-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 15-Jan-2020 às 17:08
-- Versão do servidor: 10.1.10-MariaDB
-- PHP Version: 5.5.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `teste_dev`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddOrEditAluno` (`_id_aluno` INT, `_nome_aluno` VARCHAR(250), `_numero_BI` VARCHAR(80), `_data_nasc` VARCHAR(50), `_nacionalidade` VARCHAR(40), `_genero` VARCHAR(20), `_telefone` VARCHAR(50), `_provincia` VARCHAR(40), `_bairro` VARCHAR(40), `_rua` VARCHAR(40), `_Nome_pai` VARCHAR(30), `_nome_mae` VARCHAR(30), `_tel_pai` VARCHAR(30), `_tel` VARCHAR(30), `_id_instituicao` INT)  BEGIN
	if _id_aluno = 0 then
		insert into aluno (nome_aluno, numero_BI, data_nasc, nacionalidade, genero, telefone, provincia, bairro, rua, Nome_pai, nome_mae, tel_pai, tel, id_instituicao)
		values (_nome_aluno, _numero_BI, _data_nasc, _nacionalidade, _genero, _telefone, _provincia, _bairro, _rua, _Nome_pai, _nome_mae, _tel_pai, _tel, _id_instituicao);
    else 
		update aluno
        set
        nome_aluno = _nome_aluno, 
        numero_BI = _numero_BI, 
        data_nasc = _data_nasc, 
        nacionalidade = _nacionalidade, 
        genero = _genero, 
        telefone = _telefone, 
        provincia = _provincia, 
        bairro = _bairro, 
        rua = _rua, 
        Nome_pai = _Nome_pai, 
        nome_mae = _nome_mae, 
        tel_pai = _tel_pai, 
        tel = _tel, 
        id_instituicao = _id_instituicao;
	end if;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddOrEditDisciplina` (`_id_disciplina` INT, `_disciplina` VARCHAR(50), `_id_classe` INT, `_id_professor` INT, `_id_instituicao` INT)  BEGIN

	if _id_disciplina = 0 then
		insert into disciplina (disciplina, id_classe, id_professor, id_instituicao)
		values (_disciplina, _id_classe, _id_professor, _id_instituicao);
	else 
		update disciplina
        set
			disciplina = _disciplina,
            id_classe = _id_classe,
            id_professor = _id_professor,
            id_instituicao = _id_instituicao
            where id_disciplina = _id_disciplina;
            End if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddOrEditInstituicao` (`_id_instituicao` INT, `_nome` VARCHAR(50), `_email` VARCHAR(100), `_logo` VARCHAR(100), `_provincia` VARCHAR(50), `_rua` VARCHAR(50), `_bairro` VARCHAR(50), `_tel1` VARCHAR(30), `_tel2` VARCHAR(30))  BEGIN
	if _id_instituicao = 0 then
    insert into tb_instituicao(nome, email, logo, provincia, rua, bairro, tel1, tel2)
    values (_nome, _email, _logo, _provincia, _rua, _bairro, _tel1, _tel2);
    else 
    update tb_instituicao
    set
    nome = _nome, 
    email = _email, 
    logo = _logo, 
    provincia = _provincia, 
    rua = _rua, 
    bairro = _bairro, 
    tel1 = _tel1, 
    tel2 = _tel2
    where id_instituicao = _id_instituicao;
    end if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddOrEditMatricula` (`_id_matricula` INT, `_num_estudante` INT, `_classe` VARCHAR(100), `_curso` VARCHAR(100), `_turma` VARCHAR(50), `_turno` VARCHAR(100), `_tipo_estudante` VARCHAR(100), `_num_matricula` INT, `_propina` VARCHAR(100), `_id_aluno` INT)  BEGIN
	if _id_matricula = 0 then
		insert into tb_matricula(num_estudante, classe, curso, turma, turno, tipo_estudante, num_matricula, propina, id_aluno)
		values(_num_estudante, _classe, _curso, _turma, _turno, _tipo_estudante, _num_matricula, _propina, _id_aluno);
	else
		update tb_matricula
        set
        num_estudante = _num_estudante, 
        classe = _classe, 
        curso = _curso, 
        turma = _turma, 
        turno = _turno, 
        tipo_estudante = _tipo_estudante, 
        num_matricula = _num_matricula, 
        propina = _propina, 
        id_aluno = _id_aluno;
	end if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddOrEditPagamento` (`_id_pagamento` INT, `_meses` VARCHAR(100), `_quantidade` VARCHAR(50), `_forma_pag` VARCHAR(100), `_multa` VARCHAR(100), `_total` VARCHAR(100), `_num_recibo` INT, `_troco` VARCHAR(100), `_banco` VARCHAR(100), `_emitente` VARCHAR(100), `_data_pagamento` VARCHAR(100), `_id_matricula` INT, `_id_instituicao` INT)  BEGIN
	if _id_pagamento = 0 then
		insert into tb_pagamento (meses, quantidade, forma_pag, multa, total, num_recibo, troco, banco, emitente, data_pagamento, id_matricula, id_instituicao)
		values(_meses, _quantidade, _forma_pag, _multa, _total, _num_recibo, _troco, _banco, _emitente, _data_pagamento, _id_matricula, _id_instituicao);
    else 
		update tb_pagamento
		set 
		meses = _meses, 
		quantidade = _quantidade, 
		forma_pag = _forma_pag, 
		multa = _multa, 
		total = _total, 
		num_recibo = _num_recibo, 
		troco = _troco, 
		banco = _banco, 
		emitente = _emitente, 
		data_pagamento = _data_pagamento, 
		id_matricula = _id_matricula, 
		id_instituicao = _id_instituicao;
    
    end if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddOrEditProfessor` (`_id_professor` INT, `_nome_prof` VARCHAR(250), `_numero_BI` VARCHAR(80), `_data_nasc` VARCHAR(50), `_nacionalidade` VARCHAR(40), `_genero` VARCHAR(20), `_telefone1` VARCHAR(50), `_telefone2` VARCHAR(50), `_provincia` VARCHAR(40), `_bairro` VARCHAR(40), `_rua` VARCHAR(40), `_id_usuario` INT, `_id_instituicao` INT)  BEGIN
	if _id_professor = 0 then
		insert into professor (nome_prof, numero_BI, data_nasc, nacionalidade, genero, telefone1, telefone2, provincia, bairro, rua, id_usuario, id_instituicao)
		values (_nome_prof, _numero_BI, _data_nasc, _nacionalidade, _genero, _telefone1, _telefone2, _provincia, _bairro, _rua, _id_usuario, _id_instituicao);
    else 
		update professor
        set
        nome_prof = _nome_prof, 
        numero_BI = _numero_BI, 
        data_nasc = _data_nasc, 
        nacionalidade = _nacionalidade, 
        genero = _genero, 
        telefone1 = _telefone1, 
        telefone2 = _telefone2, 
        provincia = _provincia, 
        bairro = _bairro, 
        rua = _rua, 
        id_usuario= _id_usuario,
        id_instituicao = _id_instituicao
		where id_professor = _id_professor;
	end if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddOrEditUsuario` (`_id_usuario` INT, `_nome` VARCHAR(50), `_email` VARCHAR(100), `_senha` VARCHAR(100), `_data` VARCHAR(100), `_niveldeacesso` VARCHAR(100), `_foto` TEXT, `_id_instituicao` INT)  BEGIN

	if _id_usuario = 0 then
		insert into usuario (nome, email, senha, data, niveldeacesso, foto, id_instituicao)
		values (_nome, _email, _senha, _data, _niveldeacesso, _foto, _id_instituicao);
	else 
		update usuario
        set
			nome = _nome,
            email = _email,
            senha = _senha,
            data = _data,
            niveldeacesso = _niveldeacesso,
            foto = _foto,
            id_instituicao = _id_instituicao
            where id_usuario = _id_usuario;
            End if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteAluno` (`_id_aluno` INT)  BEGIN
	Delete from aluno where id_aluno = _id_aluno;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteInstituicao` (`_id_instituicao` INT)  BEGIN
	DELETE FROM tb_instituicao WHERE id_instituicao = _id_instituicao;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteUser` (`_id_usuario` INT)  BEGIN
	DELETE FROM usuario WHERE id_usuario = _id_usuario;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `login` (`_email` VARCHAR(100), `_senha` VARCHAR(100))  BEGIN
	select nome, email, senha, tipo_aluno, foto, id_instituicao from usuario where email= _email and senha= _senha;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PesqInstituicao` (`_pesquisar` VARCHAR(45))  BEGIN
	select * from tb_instituicao
    where nome like concat('%',_pesquisar,'%') || email like concat('%',_pesquisar,'%');
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PesqUser` (`_pesquisar` VARCHAR(45))  BEGIN
	select * from usuario
    where nome like concat('%',_pesquisar,'%') || id_usuario like concat('%',_pesquisar,'%') || email like concat('%',_pesquisar,'%') || tipo_aluno like concat('%',_pesquisar,'%');
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VisualizarAluno` (`_id_instituicao` INT)  BEGIN
	SELECT * FROM aluno where id_instituicao=_id_instituicao;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `visualizarInstituicao` ()  BEGIN
	select * from tb_instituicao;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VisualizarMatricula` ()  BEGIN
	select m.curso, m.classe, m.turma, m.turno, m.propina, al.nome_aluno, al.data_nasc, al.numero_BI, al.nacionalidade  from tb_matricula m  inner join aluno al where m.tipo_estudante =  'Normal';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VisualizarUser` ()  BEGIN
	
    
    
    select us.id_usuario, us.nome, us.email, us.niveldeacesso, inst.nome  from usuario us inner join tb_instituicao inst on us.id_instituicao=inst.id_instituicao;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aluno`
--

CREATE TABLE `aluno` (
  `id_aluno` int(11) NOT NULL,
  `nome_aluno` varchar(250) DEFAULT NULL,
  `numero_BI` varchar(80) DEFAULT NULL,
  `data_nasc` varchar(50) NOT NULL,
  `nacionalidade` varchar(40) NOT NULL,
  `genero` varchar(20) NOT NULL,
  `telefone` varchar(50) NOT NULL,
  `provincia` varchar(40) NOT NULL,
  `bairro` varchar(40) NOT NULL,
  `rua` varchar(40) NOT NULL,
  `Nome_pai` varchar(30) NOT NULL,
  `nome_mae` varchar(30) NOT NULL,
  `tel_pai` varchar(30) NOT NULL,
  `tel` varchar(30) NOT NULL,
  `id_instituicao` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `aluno`
--

INSERT INTO `aluno` (`id_aluno`, `nome_aluno`, `numero_BI`, `data_nasc`, `nacionalidade`, `genero`, `telefone`, `provincia`, `bairro`, `rua`, `Nome_pai`, `nome_mae`, `tel_pai`, `tel`, `id_instituicao`) VALUES
(4, 'Eduardo de Brito', '123324234LA043', '10/01/2020', 'Angolano', 'Masculino', '934001880', 'Luanda', 'Futungo', '28 de Agosto', 'Victor Brito', 'Palmira Cristina', '923315401', '949643844', 1),
(6, 'Emanuel Pacavira', '12345678LA922', '12/06/1999', 'Angolano', 'Masculino', '987654321', 'Luanda', 'Benfica', 'Marinha', 'Domingos', 'Margarida', '987654321', '987654321', 1),
(7, 'Jennifer Brito', '1234589122LA321', '16/05/2003', 'Angolana', 'Feminino', '987654321', 'Luanda', 'Futungo', '28 de Agosto', 'Victor', 'Palmira', '987654321', '987654321', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `classe`
--

CREATE TABLE `classe` (
  `id_classe` int(11) NOT NULL,
  `classe` varchar(30) NOT NULL,
  `propina` varchar(30) NOT NULL,
  `curso` varchar(30) NOT NULL,
  `id_instituicao` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `classe`
--

INSERT INTO `classe` (`id_classe`, `classe`, `propina`, `curso`, `id_instituicao`) VALUES
(3, '10ª Classe', '15.000,00', 'CFB', 1),
(6, '11ª Classe', '16.200,00', 'GSI', 1),
(7, '12ª Classe', '15.400,00', 'GSI', 1),
(8, '10ª Classe', '15.000,00', 'CEJ', 1),
(9, '10ª Classe', '15.400,00', 'Quimica', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso`
--

CREATE TABLE `curso` (
  `id_curso` int(11) NOT NULL,
  `curso` varchar(30) NOT NULL,
  `id_instituicao` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `disciplina`
--

CREATE TABLE `disciplina` (
  `id_disciplina` int(11) NOT NULL,
  `disciplina` varchar(30) NOT NULL,
  `id_classe` int(11) DEFAULT NULL,
  `id_professor` int(11) DEFAULT NULL,
  `id_instituicao` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `disciplina`
--

INSERT INTO `disciplina` (`id_disciplina`, `disciplina`, `id_classe`, `id_professor`, `id_instituicao`) VALUES
(1, 'TLP', 6, 2, 1),
(2, 'TLP', 7, 1, 1),
(3, 'Fisíca', 9, 3, 1),
(4, 'TIC', 7, 2, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `professor`
--

CREATE TABLE `professor` (
  `id_professor` int(11) NOT NULL,
  `nome_prof` varchar(250) DEFAULT NULL,
  `numero_BI` varchar(80) DEFAULT NULL,
  `data_nasc` varchar(50) NOT NULL,
  `nacionalidade` varchar(40) NOT NULL,
  `genero` varchar(20) NOT NULL,
  `telefone1` varchar(50) NOT NULL,
  `telefone2` varchar(30) NOT NULL,
  `provincia` varchar(40) NOT NULL,
  `bairro` varchar(40) NOT NULL,
  `rua` varchar(40) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `id_instituicao` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `professor`
--

INSERT INTO `professor` (`id_professor`, `nome_prof`, `numero_BI`, `data_nasc`, `nacionalidade`, `genero`, `telefone1`, `telefone2`, `provincia`, `bairro`, `rua`, `id_usuario`, `id_instituicao`) VALUES
(1, 'Mimosa Cabata', '0009398LA93', '09/11/1998', 'Angolana', 'Masculino', '928281222', '928281222', 'Luanda', 'Talatona', '29T32', 11, 1),
(2, 'Maria Manuel José', '0009398LA021', '09/11/1988', 'Angolano', 'Masculino', '928281222', '918281222', 'Luanda', 'Talatona', '29T32', 9, 1),
(3, 'José Cabaça', '0009398LA030', '09/11/1982', 'Angolano', 'Masculino', '928281222', '928281222', 'Luanda', 'Benfica', 'As Salinas', 12, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_instituicao`
--

CREATE TABLE `tb_instituicao` (
  `id_instituicao` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `logo` varchar(100) DEFAULT NULL,
  `provincia` varchar(50) DEFAULT NULL,
  `rua` varchar(50) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `tel1` varchar(30) DEFAULT NULL,
  `tel2` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_instituicao`
--

INSERT INTO `tb_instituicao` (`id_instituicao`, `nome`, `email`, `logo`, `provincia`, `rua`, `bairro`, `tel1`, `tel2`) VALUES
(1, 'Cemu', 'cemu@gamil.com', 'MeuLogo', 'Luanda', 'Partido', 'Benfica', '+244(912-345-678)', '+244(922-345-679)'),
(2, 'Girassol', 'girassol@gmail.com', 'Foto Padrao', 'Luanda', 'Sei La', 'Morro Bento', '921333333', '991333333'),
(3, 'Mona Tower', 'mn@mn.co.ao', 'foto', 'Luanda', 'Av. 21', 'Talatona', '987654321', '987654321');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_matricula`
--

CREATE TABLE `tb_matricula` (
  `id_matricula` int(11) NOT NULL,
  `num_estudante` int(11) DEFAULT NULL,
  `curso` varchar(100) DEFAULT NULL,
  `turma` varchar(50) DEFAULT NULL,
  `turno` varchar(100) DEFAULT NULL,
  `tipo_estudante` varchar(100) DEFAULT NULL,
  `num_matricula` int(11) DEFAULT NULL,
  `propina` varchar(100) DEFAULT NULL,
  `id_aluno` int(11) NOT NULL,
  `id_classe` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_matricula`
--

INSERT INTO `tb_matricula` (`id_matricula`, `num_estudante`, `curso`, `turma`, `turno`, `tipo_estudante`, `num_matricula`, `propina`, `id_aluno`, `id_classe`) VALUES
(1, 12, 'CEJ', 'A', 'Tarde', 'Bolseiro', 112345, '12.000', 4, 8),
(2, 12, 'CEJ', 'a', 'Manhã', 'Normal', 12345, '12.000', 7, 7);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_meses`
--

CREATE TABLE `tb_meses` (
  `id_meses` int(11) NOT NULL,
  `mes` varchar(40) NOT NULL,
  `id_aluno` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_meses`
--

INSERT INTO `tb_meses` (`id_meses`, `mes`, `id_aluno`) VALUES
(2, 'Fevereiro', 4),
(3, 'Fevereiro', 4),
(4, 'Fevereiro', 4),
(5, 'Fevereiro', 6),
(6, 'Fevereiro', 4),
(7, 'Fevereiro', 4),
(8, 'Fevereiro', 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_pagamento`
--

CREATE TABLE `tb_pagamento` (
  `id_pagamento` int(11) NOT NULL,
  `meses` varchar(100) DEFAULT NULL,
  `quantidade` varchar(50) DEFAULT NULL,
  `forma_pag` varchar(100) DEFAULT NULL,
  `multa` varchar(100) DEFAULT NULL,
  `total` varchar(100) DEFAULT NULL,
  `num_recibo` int(11) DEFAULT NULL,
  `troco` varchar(100) DEFAULT NULL,
  `banco` varchar(100) DEFAULT NULL,
  `emitente` varchar(100) DEFAULT NULL,
  `data_pagamento` varchar(100) DEFAULT NULL,
  `id_matricula` int(11) DEFAULT NULL,
  `id_instituicao` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `senha` varchar(100) DEFAULT NULL,
  `data` varchar(100) NOT NULL,
  `niveldeacesso` varchar(100) NOT NULL,
  `foto` text,
  `id_instituicao` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `nome`, `email`, `senha`, `data`, `niveldeacesso`, `foto`, `id_instituicao`) VALUES
(2, 'Eduardo', 'admin', 'admin', '02-01-2020 :17: 38 : 49', 'Administrador Geral', 'asdas', 1),
(7, 'Emanuel Pacavira', 'paca@gmail.com', '1234', '11-01-2020 :14: 40 : 53', 'Estudante', '', 1),
(8, 'Kambaia Alberto', 'k@gmail.com', '1111', '10-01-2020 :14: 13 : 25', 'Administrador da Escola', '', 2),
(9, 'Maria Manuel', 'maria@gmail.com', '1234', '11-01-2020 :14: 41 : 25', 'Professor', '', 1),
(10, 'Carlos Gabriel', 'cg@outlook.pt', '1234', '11-01-2020 :14: 30 : 08', 'Administrador  da Escola', 'ft', 3),
(11, 'Mimosa Cabata', 'mimosacabata@gmail.com', '2212', '13-01-2020 :12: 53 : 10', 'Professor', '', 1),
(12, 'José Cabaça Da foseca', 'josecabaca@gmail.com', '2212', '13-01-2020 :13: 02 : 16', 'Professor', '', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aluno`
--
ALTER TABLE `aluno`
  ADD PRIMARY KEY (`id_aluno`),
  ADD KEY `id_instituicao` (`id_instituicao`);

--
-- Indexes for table `classe`
--
ALTER TABLE `classe`
  ADD PRIMARY KEY (`id_classe`),
  ADD KEY `id_instituicao` (`id_instituicao`);

--
-- Indexes for table `curso`
--
ALTER TABLE `curso`
  ADD KEY `id_instituicao` (`id_instituicao`);

--
-- Indexes for table `disciplina`
--
ALTER TABLE `disciplina`
  ADD PRIMARY KEY (`id_disciplina`),
  ADD KEY `id_professor` (`id_professor`),
  ADD KEY `id_classe` (`id_classe`),
  ADD KEY `id_instituicao` (`id_instituicao`);

--
-- Indexes for table `professor`
--
ALTER TABLE `professor`
  ADD PRIMARY KEY (`id_professor`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_instituicao` (`id_instituicao`);

--
-- Indexes for table `tb_instituicao`
--
ALTER TABLE `tb_instituicao`
  ADD PRIMARY KEY (`id_instituicao`);

--
-- Indexes for table `tb_matricula`
--
ALTER TABLE `tb_matricula`
  ADD PRIMARY KEY (`id_matricula`),
  ADD UNIQUE KEY `id_aluno` (`id_aluno`),
  ADD KEY `id_classe` (`id_classe`);

--
-- Indexes for table `tb_meses`
--
ALTER TABLE `tb_meses`
  ADD PRIMARY KEY (`id_meses`),
  ADD KEY `id_aluno` (`id_aluno`);

--
-- Indexes for table `tb_pagamento`
--
ALTER TABLE `tb_pagamento`
  ADD PRIMARY KEY (`id_pagamento`),
  ADD UNIQUE KEY `id_matricula` (`id_matricula`),
  ADD UNIQUE KEY `id_instituicao` (`id_instituicao`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD KEY `usuario_ibfk_1` (`id_instituicao`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aluno`
--
ALTER TABLE `aluno`
  MODIFY `id_aluno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `classe`
--
ALTER TABLE `classe`
  MODIFY `id_classe` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `disciplina`
--
ALTER TABLE `disciplina`
  MODIFY `id_disciplina` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `professor`
--
ALTER TABLE `professor`
  MODIFY `id_professor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tb_instituicao`
--
ALTER TABLE `tb_instituicao`
  MODIFY `id_instituicao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tb_matricula`
--
ALTER TABLE `tb_matricula`
  MODIFY `id_matricula` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tb_meses`
--
ALTER TABLE `tb_meses`
  MODIFY `id_meses` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `tb_pagamento`
--
ALTER TABLE `tb_pagamento`
  MODIFY `id_pagamento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `aluno`
--
ALTER TABLE `aluno`
  ADD CONSTRAINT `aluno_ibfk_1` FOREIGN KEY (`id_instituicao`) REFERENCES `tb_instituicao` (`id_instituicao`);

--
-- Limitadores para a tabela `classe`
--
ALTER TABLE `classe`
  ADD CONSTRAINT `classe_ibfk_1` FOREIGN KEY (`id_instituicao`) REFERENCES `tb_instituicao` (`id_instituicao`);

--
-- Limitadores para a tabela `curso`
--
ALTER TABLE `curso`
  ADD CONSTRAINT `curso_ibfk_1` FOREIGN KEY (`id_instituicao`) REFERENCES `tb_instituicao` (`id_instituicao`);

--
-- Limitadores para a tabela `disciplina`
--
ALTER TABLE `disciplina`
  ADD CONSTRAINT `disciplina_ibfk_2` FOREIGN KEY (`id_professor`) REFERENCES `professor` (`id_professor`),
  ADD CONSTRAINT `disciplina_ibfk_3` FOREIGN KEY (`id_classe`) REFERENCES `classe` (`id_classe`),
  ADD CONSTRAINT `disciplina_ibfk_4` FOREIGN KEY (`id_instituicao`) REFERENCES `tb_instituicao` (`id_instituicao`);

--
-- Limitadores para a tabela `professor`
--
ALTER TABLE `professor`
  ADD CONSTRAINT `professor_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`),
  ADD CONSTRAINT `professor_ibfk_2` FOREIGN KEY (`id_instituicao`) REFERENCES `tb_instituicao` (`id_instituicao`);

--
-- Limitadores para a tabela `tb_matricula`
--
ALTER TABLE `tb_matricula`
  ADD CONSTRAINT `matricula_e_aluno` FOREIGN KEY (`id_aluno`) REFERENCES `aluno` (`id_aluno`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_matricula_ibfk_1` FOREIGN KEY (`id_classe`) REFERENCES `classe` (`id_classe`);

--
-- Limitadores para a tabela `tb_meses`
--
ALTER TABLE `tb_meses`
  ADD CONSTRAINT `tb_meses_ibfk_1` FOREIGN KEY (`id_aluno`) REFERENCES `aluno` (`id_aluno`);

--
-- Limitadores para a tabela `tb_pagamento`
--
ALTER TABLE `tb_pagamento`
  ADD CONSTRAINT `pagamento_e_instituicao` FOREIGN KEY (`id_instituicao`) REFERENCES `tb_instituicao` (`id_instituicao`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pagemento_e_matricula` FOREIGN KEY (`id_matricula`) REFERENCES `tb_matricula` (`id_matricula`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`id_instituicao`) REFERENCES `tb_instituicao` (`id_instituicao`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
