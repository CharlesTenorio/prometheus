-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19-Jun-2021 às 16:03
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_congo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `atendimento`
--

CREATE TABLE `atendimento` (
  `id_atendimento` int(11) NOT NULL,
  `id_chamado` int(11) NOT NULL,
  `status_final` varchar(100) NOT NULL,
  `data_inicial` date NOT NULL,
  `data_final` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `bairro`
--

CREATE TABLE `bairro` (
  `id_bairro` int(11) NOT NULL,
  `bairro` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `bairro`
--

INSERT INTO `bairro` (`id_bairro`, `bairro`) VALUES
(1, 'Boa Vista'),
(2, 'Centro'),
(5, 'Veraneio'),
(6, 'Caraibas'),
(7, 'Malhada'),
(8, 'Rua velha'),
(9, 'Aldeia velha'),
(10, 'Fazenda Moco'),
(11, 'Vila velha');

-- --------------------------------------------------------

--
-- Estrutura da tabela `chamado`
--

CREATE TABLE `chamado` (
  `id_chamado` int(11) NOT NULL,
  `id_cidadao` int(11) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `rua` varchar(250) NOT NULL,
  `numero` varchar(10) NOT NULL,
  `bairro` varchar(200) NOT NULL,
  `cidade` varchar(250) NOT NULL,
  `ponto` varchar(250) NOT NULL,
  `id_demanda` int(11) NOT NULL,
  `descricao_demanda` text NOT NULL,
  `data_demanda` datetime NOT NULL,
  `foto` varchar(350) NOT NULL,
  `status_ch` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `chamado`
--

INSERT INTO `chamado` (`id_chamado`, `id_cidadao`, `cep`, `rua`, `numero`, `bairro`, `cidade`, `ponto`, `id_demanda`, `descricao_demanda`, `data_demanda`, `foto`, `status_ch`) VALUES
(1, 3, '56519340', 'Rua Três', '2', 'Boa Vista', 'Arcoverde', 'Subida do Bar do Soro ', 8, 'buraco na rua principal na subida do ônibus', '2021-01-18 08:46:42', 'fdc43ac022d39eb1dc45b7ad996e89f7.jpg', 'inloco'),
(2, 3, '56508210', 'Rua Agamenon-3', '3', 'Boa Esperança', 'Arcoverde', 'Na rua do vice prefeito', 5, 'metralha na rua gerando muita poeira', '2021-01-18 10:31:54', '0e9e801c2050846eee6a9c5aca2245e2.jpg', 'feito'),
(3, 4, '56500.000', 'rua nova', '27', 'Centro universitário', 'arcoverde', 'perto do sporte club', 1, 'galeria entupida', '2021-01-29 15:59:53', '3e61335037e5bfc987dc783e9ddd9c33.jpg', 'Em aberto'),
(4, 5, '56508210', 'Rua Agamenon-3', '3', 'Boa Esperança', 'Arcoverde', 'Subida do Bar do Soro ', 12, 'arvore na rua', '2021-02-02 14:00:57', 'fc47d7f83953d8091577cefb56d6d4fe.jpg', 'Em aberto');

-- --------------------------------------------------------

--
-- Estrutura da tabela `checklist`
--

CREATE TABLE `checklist` (
  `id_check` int(11) NOT NULL,
  `id_veiculo` int(11) NOT NULL,
  `data_check` date NOT NULL,
  `KmVeiculo` varchar(20) NOT NULL,
  `resposavel_inspecao` varchar(200) NOT NULL,
  `Nome_motorista` varchar(200) NOT NULL,
  `N_oleo_do_motor` varchar(20) NOT NULL,
  `N_do_fluido__freio` varchar(20) NOT NULL,
  `N_agua_limp_parabrisa` varchar(20) NOT NULL,
  `agua_radiador` varchar(20) NOT NULL,
  `Bateria_veiculo_serie` varchar(20) NOT NULL,
  `limpador_parabrisa` varchar(20) NOT NULL,
  `Luzes` varchar(20) NOT NULL,
  `Condicoes_carroceria` varchar(50) NOT NULL,
  `Pressao_dos_pneus` varchar(20) NOT NULL,
  `Sulco_dos_pneus` varchar(20) NOT NULL,
  `Pastilhas_de_freio` varchar(20) NOT NULL,
  `Pneu_reserva` varchar(20) NOT NULL,
  `Cinto_segurança` varchar(20) NOT NULL,
  `Extintor_incêndio` varchar(20) NOT NULL,
  `Kitdeseguranca_emergência` varchar(20) NOT NULL,
  `Documentodoveiculo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cidadao`
--

CREATE TABLE `cidadao` (
  `id_cidadao` int(11) NOT NULL,
  `nome` varchar(250) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `endereco` varchar(300) NOT NULL,
  `numero` varchar(10) NOT NULL,
  `bairro` varchar(200) NOT NULL,
  `email` varchar(35) NOT NULL,
  `whatsapp` varchar(20) NOT NULL,
  `senha` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cidadao`
--

INSERT INTO `cidadao` (`id_cidadao`, `nome`, `cpf`, `cep`, `endereco`, `numero`, `bairro`, `email`, `whatsapp`, `senha`) VALUES
(1, 'Charleu Tenorio', '041.547.834-08', '56519465', 'Rua G', '02', 'Bela vista nova', 'charleu@hotmail.com', '(87)99316018', '2214'),
(2, 'Charleu Tenorio', '041.547.834-08', '56519465', 'Rua G', '02', 'Bela vista nova', 'charleu@hotmail.com', '(87)99316018', '2214'),
(3, 'cicera rodrigues', '041.547.834-08', '56179', 'Rua 03', '2', 'Bela vista nova', 'cicerarlm@hotmail.com', '(87)99316088', 'cicera22'),
(4, 'Karol Leite', '043.567.834-09', '56000.000', 'rua da hora', '34', 'Centro', 'karol@hotmail.com', '8738221921', 'BB123'),
(5, 'Karol Leite', '098763456-09', '56000.000', 'rua b', '2', 'Boa Vista', 'karol2@hotmail.com', '8798888', '123456');

-- --------------------------------------------------------

--
-- Estrutura da tabela `demanda`
--

CREATE TABLE `demanda` (
  `id_demanda` int(11) NOT NULL,
  `demanda` varchar(250) NOT NULL,
  `cod_demanda` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `demanda`
--

INSERT INTO `demanda` (`id_demanda`, `demanda`, `cod_demanda`) VALUES
(1, 'GALERIA', 'G1'),
(2, 'HIDRO JATO', 'H1'),
(3, 'PAVIMENTO E GALERIA', 'P1G1'),
(4, 'REPOSIÇÃO DE PAVIMENTAÇÃO E GALERIA', 'R1P1G1'),
(5, 'METRALHA E ENTULHO', 'M1'),
(7, 'TROCA DE LÂMPADA', 'L1'),
(8, 'BURACO NA RUA', 'B1'),
(9, 'LIMPEZA URBANA', 'LU1'),
(10, 'LIMPEZA DE TERRENO', 'LT1'),
(11, 'RESIDUOS HOSPITALARES', 'RH1'),
(12, 'PODAÇÃO EM GERAL', 'F1'),
(13, 'Cortar Arvores', 'AR21'),
(14, 'Limpeza de pátio escolar', 'LPE'),
(15, 'Limpeza de cemitério', 'AR34'),
(16, 'Galeria2', 'G2'),
(17, 'Galeria3', 'G3'),
(18, 'Galeria4', 'G3');

-- --------------------------------------------------------

--
-- Estrutura da tabela `detalhe_atendimento`
--

CREATE TABLE `detalhe_atendimento` (
  `id_det_atendimento` int(11) NOT NULL,
  `id_equipe` int(11) NOT NULL,
  `descricao_tec` text NOT NULL,
  `descricao_solucao` text NOT NULL,
  `status` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `endereco`
--

CREATE TABLE `endereco` (
  `id_endereco` int(11) NOT NULL,
  `id_os_simples` int(11) NOT NULL,
  `Endereco` varchar(250) NOT NULL,
  `numero` varchar(10) NOT NULL,
  `bairro` varchar(200) NOT NULL,
  `complemento` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `equipe`
--

CREATE TABLE `equipe` (
  `id_equipe` int(11) NOT NULL,
  `equipe` varchar(150) NOT NULL,
  `id_funcionario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcao`
--

CREATE TABLE `funcao` (
  `id_funcao` int(11) NOT NULL,
  `funcao` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcao`
--

INSERT INTO `funcao` (`id_funcao`, `funcao`) VALUES
(1, 'Motorista'),
(2, 'Encanador'),
(3, 'Eletricista'),
(4, 'Ajudante'),
(5, 'Mestre de Obras'),
(6, 'Engenheiro Ambiental'),
(7, 'Engenheiro Civil'),
(8, 'Programador'),
(9, 'Carpinteiro'),
(15, 'Fiscal'),
(16, 'Sistema');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `id_funcionario` int(11) NOT NULL,
  `funcionario` varchar(250) NOT NULL,
  `cpf` varchar(25) NOT NULL,
  `fone` varchar(20) NOT NULL,
  `id_funcao` int(11) NOT NULL,
  `data_cad` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`id_funcionario`, `funcionario`, `cpf`, `fone`, `id_funcao`, `data_cad`) VALUES
(1, 'Sistema', '111111', '1111', 15, '2021-01-12'),
(2, 'João Alberto', '02157256302', '879909090', 6, '2021-01-12'),
(4, 'Rose Lima teste', '098763456-09', '8798888', 6, '2021-01-15'),
(5, 'jose arnaldo', '091.345.834-08', '87999991-2666', 15, '2021-02-19');

-- --------------------------------------------------------

--
-- Estrutura da tabela `lampada`
--

CREATE TABLE `lampada` (
  `id_lampada` int(11) NOT NULL,
  `sigla` varchar(3) NOT NULL,
  `lampada` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `lampada`
--

INSERT INTO `lampada` (`id_lampada`, `sigla`, `lampada`) VALUES
(2, 'VS', 'Lâmpada Vapor de Sódio'),
(3, 'VM', 'Lâmpada Vapor de Mercúrio'),
(4, 'ME', 'Lâmpada Vapor de Metálico'),
(5, 'HL', 'Lâmpada Halogêna'),
(6, 'MS', 'Lâmpada Mista'),
(7, 'PL', 'Lâmpada Fluorescente'),
(8, 'LD', 'Lâmpada de LED');

-- --------------------------------------------------------

--
-- Estrutura da tabela `lampada_senso`
--

CREATE TABLE `lampada_senso` (
  `id_ls` int(11) NOT NULL,
  `sequencial` int(11) NOT NULL,
  `transformador` varchar(10) NOT NULL,
  `endereco` varchar(250) NOT NULL,
  `numero` int(11) NOT NULL,
  `id_bairro` int(11) NOT NULL,
  `complemento` varchar(150) NOT NULL,
  `nposter` varchar(10) NOT NULL,
  `estrutura` varchar(150) NOT NULL,
  `id_lampada` int(11) NOT NULL,
  `potencia` int(11) NOT NULL,
  `Qdt` int(11) NOT NULL,
  `medidor` varchar(3) NOT NULL,
  `obs` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `lampada_senso`
--

INSERT INTO `lampada_senso` (`id_ls`, `sequencial`, `transformador`, `endereco`, `numero`, `id_bairro`, `complemento`, `nposter`, `estrutura`, `id_lampada`, `potencia`, `Qdt`, `medidor`, `obs`) VALUES
(1, 1, 'A12345', 'Rua 03', 2, 2, '0', 'G562314', 'Companhia', 8, 20, 3, 'SIM', '20201');

-- --------------------------------------------------------

--
-- Estrutura da tabela `material`
--

CREATE TABLE `material` (
  `id_material` int(11) NOT NULL,
  `descricao` varchar(250) NOT NULL,
  `Qtd` int(11) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `Qtd_min` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `os`
--

CREATE TABLE `os` (
  `id_os` int(11) NOT NULL,
  `data_os` date NOT NULL,
  `id_demanda` int(11) NOT NULL,
  `id_fucionario` int(11) NOT NULL,
  `id_rua` int(11) NOT NULL,
  `id_bairro` int(11) NOT NULL,
  `numero` int(11) NOT NULL,
  `tipo_solicitante` varchar(120) NOT NULL,
  `solicitante` varchar(250) NOT NULL,
  `fone_solicitante` varchar(25) NOT NULL,
  `id_prioridade` int(11) NOT NULL,
  `especificacao_servico` text NOT NULL,
  `observacao` text NOT NULL,
  `status_ser` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `os`
--

INSERT INTO `os` (`id_os`, `data_os`, `id_demanda`, `id_fucionario`, `id_rua`, `id_bairro`, `numero`, `tipo_solicitante`, `solicitante`, `fone_solicitante`, `id_prioridade`, `especificacao_servico`, `observacao`, `status_ser`) VALUES
(1, '2021-01-21', 1, 1, 2, 2, 2, 'populacao', 'Karol Leite', '8798888', 1, 'Desobstruir Galeria', 'galeria com mau cheiro', 'feito'),
(2, '2021-01-21', 7, 1, 3, 2, 25, 'vereador', 'João Silva', '87 909090', 1, 'troca de lâmpada', 'poste numero 1112', 'aberto'),
(3, '2021-01-21', 1, 2, 1, 3, 25, 'secretaria', 'Karol Leite', '8798888', 2, 'uso de hidro jato', '', 'aberto'),
(4, '2021-01-27', 3, 2, 3, 5, 3, 'vereador', 'jose padilha', '8798888', 3, 'pavimento galeria', 'pedra', 'aberto'),
(5, '2021-01-27', 2, 2, 3, 5, 3, '1', 'Luciando pacheco', '8798888', 1, 'Desobstruir Galeria', 'uso de hidro jato', 'aberto'),
(6, '2021-01-28', 5, 2, 2, 2, 25, '1', 'João Silva', '8798888', 1, 'Desobstruir Galeria', 'testesteet', 'aberto'),
(7, '2021-02-01', 1, 2, 1, 1, 2, 'secretaria', 'João Silva', '87 909090', 3, 'Desobstruir Galeria', 'rua com galeria estourada', 'aberto'),
(8, '2021-02-02', 4, 2, 2, 1, 2, 'populacao', 'vera lucia', '8798888', 2, 'Desobstruir Galeria', 'testes', 'aberto'),
(9, '2021-02-18', 9, 2, 1, 1, 2, 'populacao', 'vera lucia', '8798888', 1, 'troca de lâmpada', 'trtrtre', 'aberto'),
(10, '2021-02-19', 1, 5, 10, 2, 367, 'populacao', 'Renata', '87 909090', 1, 'Desobstruir Galeria', 'tetes', 'feito'),
(11, '2021-05-03', 4, 2, 1, 1, 2, 'vereador', 'Joanna Brasil', '38216363', 1, 'Galeria obstruída', 'galeria nova', 'aberto');

-- --------------------------------------------------------

--
-- Estrutura da tabela `os_simples`
--

CREATE TABLE `os_simples` (
  `id_os_simples` int(11) NOT NULL,
  `id_bairro` int(11) NOT NULL,
  `id_usuario_app` int(11) NOT NULL,
  `id_tipo_servico` int(11) NOT NULL,
  `descricao_problema` text NOT NULL,
  `prioridade` varchar(100) NOT NULL,
  `tipo_solicitante` varchar(100) NOT NULL,
  `data_abertura` datetime NOT NULL,
  `data_fechamento` datetime NOT NULL,
  `id_funcionario` int(11) NOT NULL,
  `estado` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `os_simples`
--

INSERT INTO `os_simples` (`id_os_simples`, `id_bairro`, `id_usuario_app`, `id_tipo_servico`, `descricao_problema`, `prioridade`, `tipo_solicitante`, `data_abertura`, `data_fechamento`, `id_funcionario`, `estado`) VALUES
(1, 1, 3, 1, 'teste', '1', 'População', '2021-05-02 11:46:25', '2021-05-02 11:46:25', 1, 'Em Aberto'),
(2, 5, 3, 4, 'falta calçamento', '1', 'População', '2021-05-02 11:47:43', '2021-05-02 11:47:43', 1, 'Em Aberto'),
(3, 1, 3, 1, 'esgouto estourado', '1', 'População', '2021-05-02 11:50:25', '2021-05-02 11:50:25', 1, 'Em Aberto'),
(4, 1, 3, 5, 'rua com metralha', '1', 'População', '2021-05-02 11:57:23', '2021-05-02 11:57:23', 1, 'Em Aberto'),
(5, 6, 3, 14, 'Escola do sítio suja', '1', 'População', '2021-05-02 13:27:04', '2021-05-02 13:27:04', 1, 'Em Aberto'),
(6, 10, 4, 9, 'Rua onde moro cheia de lixo', '1', 'População', '2021-05-02 18:56:54', '2021-05-02 18:56:54', 1, 'Em Aberto');

-- --------------------------------------------------------

--
-- Estrutura da tabela `rota`
--

CREATE TABLE `rota` (
  `id_rota` int(11) NOT NULL,
  `id_veiculo` int(11) NOT NULL,
  `data_rota` date NOT NULL,
  `tipo_servico` varchar(200) NOT NULL,
  `localidade` varchar(200) NOT NULL,
  `data_volta` date NOT NULL,
  `obs` text NOT NULL,
  `statusr` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `rota`
--

INSERT INTO `rota` (`id_rota`, `id_veiculo`, `data_rota`, `tipo_servico`, `localidade`, `data_volta`, `obs`, `statusr`) VALUES
(1, 0, '2021-05-01', 'Retira metralha', 'Rua velha', '2021-05-01', 'nd', 'fazendo'),
(2, 2, '2021-05-01', 'Pegar pessoal', 'São cristovão', '2021-05-01', 'nd', 'fazendo'),
(3, 3, '2021-05-14', 'Retira metralha', 'Rua velha', '2021-05-14', 'em frente ao mercado', 'Feito');

-- --------------------------------------------------------

--
-- Estrutura da tabela `rua`
--

CREATE TABLE `rua` (
  `id_rua` int(11) NOT NULL,
  `nome_rua` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `rua`
--

INSERT INTO `rua` (`id_rua`, `nome_rua`) VALUES
(1, 'Rua Três'),
(2, 'Rua Augusto Cavalcanti'),
(3, 'Rua Agamenon-3'),
(8, 'Rua b'),
(9, 'Rua A'),
(10, 'Av.Joaquim nabuco');

-- --------------------------------------------------------

--
-- Estrutura da tabela `servico_feito`
--

CREATE TABLE `servico_feito` (
  `id_sf` int(11) NOT NULL,
  `id_carro` int(11) NOT NULL,
  `id_servico` int(11) NOT NULL,
  `data_sf` date NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `obs` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `servico_veiculo`
--

CREATE TABLE `servico_veiculo` (
  `id_sv` int(11) NOT NULL,
  `descricao` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `solicitacao`
--

CREATE TABLE `solicitacao` (
  `id_solicitacao` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `rua` varchar(250) NOT NULL,
  `bairro` varchar(200) NOT NULL,
  `ponto_referencia` varchar(200) NOT NULL,
  `descricao` text NOT NULL,
  `imagem` varchar(450) NOT NULL,
  `data_cad` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_estado`
--

CREATE TABLE `tbl_estado` (
  `id_estado` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_insert`
--

CREATE TABLE `tbl_insert` (
  `id` int(6) NOT NULL,
  `name` varchar(200) DEFAULT NULL,
  `country` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tbl_insert`
--

INSERT INTO `tbl_insert` (`id`, `name`, `country`) VALUES
(0, 'Izabel', 'China'),
(0, 'Izabel', 'China'),
(0, 'Izabel', 'China'),
(0, 'joao', 'Mexico'),
(0, 'izabelmarques .hopto.org', 'Please select country'),
(0, 'izabelmarques .hopto.org', 'Please select country');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_select`
--

CREATE TABLE `tbl_select` (
  `id` int(6) NOT NULL,
  `country` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tbl_select`
--

INSERT INTO `tbl_select` (`id`, `country`) VALUES
(1, 'Cambodia'),
(2, 'Mexico'),
(3, 'India'),
(4, ' France'),
(5, 'China'),
(6, 'Bermuda'),
(7, 'Australia'),
(8, 'Andorra'),
(9, 'Burundi'),
(10, 'Colombia');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL,
  `email` varchar(30) NOT NULL,
  `senha` varchar(32) NOT NULL,
  `ativo` int(11) NOT NULL,
  `nevel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `nome`, `email`, `senha`, `ativo`, `nevel`) VALUES
(1, 'charleu tenprio', 'charleu@hotmail.com', 'e3c91a73596639224ba52eee73f1a67f', 1, 2),
(2, 'Rosy', 'rosycarina1@gmail.com', '2cdfde2f551a576b76741f6fdb8ab500', 1, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculos`
--

CREATE TABLE `veiculos` (
  `id_veiculos` int(11) NOT NULL,
  `Tipo` varchar(120) NOT NULL,
  `Placa` varchar(15) NOT NULL,
  `Ano` varchar(20) NOT NULL,
  `Modelo` varchar(120) NOT NULL,
  `Motorista` varchar(250) NOT NULL,
  `N_Habilitacao` varchar(12) NOT NULL,
  `Categoria` varchar(2) NOT NULL,
  `Validade` date NOT NULL,
  `Fone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `veiculos`
--

INSERT INTO `veiculos` (`id_veiculos`, `Tipo`, `Placa`, `Ano`, `Modelo`, `Motorista`, `N_Habilitacao`, `Categoria`, `Validade`, `Fone`) VALUES
(1, 'proprio', 'klp1932', '2006', 'Trator de Esteira', 'Cazuza', '2531d', 'D', '2021-04-26', 'trator'),
(2, 'Agregado', 'klt-0676', '2006', 'Corsa Sedan', 'José Claúdio', '2531d', 'AB', '2021-04-27', 'Carro de Passeio'),
(3, 'proprio', 'bel6969', '2022', 's10 cabine dupla', 'José Roberto', '2531d', 'D', '2021-04-28', '(87)99316014'),
(4, 'proprio', 'klt-0656', '2006', 'Strada', 'José Roberto', '', 'AB', '2021-04-26', '8736221963'),
(5, 'proprio', 'THT-25363', '2006', 'Strada', 'José Roberto da silva', '20231', 'AB', '2021-04-28', '8736221963'),
(6, 'proprio', 'BOA-5964', '2022', 'Corsa Sedan', 'José Roberto', '20231', 'AB', '2021-04-27', '(87)99316014');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `atendimento`
--
ALTER TABLE `atendimento`
  ADD PRIMARY KEY (`id_atendimento`);

--
-- Índices para tabela `bairro`
--
ALTER TABLE `bairro`
  ADD PRIMARY KEY (`id_bairro`);

--
-- Índices para tabela `chamado`
--
ALTER TABLE `chamado`
  ADD PRIMARY KEY (`id_chamado`);

--
-- Índices para tabela `checklist`
--
ALTER TABLE `checklist`
  ADD PRIMARY KEY (`id_check`);

--
-- Índices para tabela `cidadao`
--
ALTER TABLE `cidadao`
  ADD PRIMARY KEY (`id_cidadao`);

--
-- Índices para tabela `demanda`
--
ALTER TABLE `demanda`
  ADD PRIMARY KEY (`id_demanda`);

--
-- Índices para tabela `detalhe_atendimento`
--
ALTER TABLE `detalhe_atendimento`
  ADD PRIMARY KEY (`id_det_atendimento`);

--
-- Índices para tabela `endereco`
--
ALTER TABLE `endereco`
  ADD PRIMARY KEY (`id_endereco`);

--
-- Índices para tabela `equipe`
--
ALTER TABLE `equipe`
  ADD PRIMARY KEY (`id_equipe`);

--
-- Índices para tabela `funcao`
--
ALTER TABLE `funcao`
  ADD PRIMARY KEY (`id_funcao`);

--
-- Índices para tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`id_funcionario`);

--
-- Índices para tabela `lampada`
--
ALTER TABLE `lampada`
  ADD PRIMARY KEY (`id_lampada`);

--
-- Índices para tabela `lampada_senso`
--
ALTER TABLE `lampada_senso`
  ADD PRIMARY KEY (`id_ls`);

--
-- Índices para tabela `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`id_material`);

--
-- Índices para tabela `os`
--
ALTER TABLE `os`
  ADD PRIMARY KEY (`id_os`);

--
-- Índices para tabela `os_simples`
--
ALTER TABLE `os_simples`
  ADD PRIMARY KEY (`id_os_simples`);

--
-- Índices para tabela `rota`
--
ALTER TABLE `rota`
  ADD PRIMARY KEY (`id_rota`);

--
-- Índices para tabela `rua`
--
ALTER TABLE `rua`
  ADD PRIMARY KEY (`id_rua`);

--
-- Índices para tabela `servico_feito`
--
ALTER TABLE `servico_feito`
  ADD PRIMARY KEY (`id_sf`);

--
-- Índices para tabela `servico_veiculo`
--
ALTER TABLE `servico_veiculo`
  ADD PRIMARY KEY (`id_sv`);

--
-- Índices para tabela `solicitacao`
--
ALTER TABLE `solicitacao`
  ADD PRIMARY KEY (`id_solicitacao`);

--
-- Índices para tabela `tbl_estado`
--
ALTER TABLE `tbl_estado`
  ADD PRIMARY KEY (`id_estado`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Índices para tabela `veiculos`
--
ALTER TABLE `veiculos`
  ADD PRIMARY KEY (`id_veiculos`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `atendimento`
--
ALTER TABLE `atendimento`
  MODIFY `id_atendimento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `bairro`
--
ALTER TABLE `bairro`
  MODIFY `id_bairro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `chamado`
--
ALTER TABLE `chamado`
  MODIFY `id_chamado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `checklist`
--
ALTER TABLE `checklist`
  MODIFY `id_check` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `cidadao`
--
ALTER TABLE `cidadao`
  MODIFY `id_cidadao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `demanda`
--
ALTER TABLE `demanda`
  MODIFY `id_demanda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `detalhe_atendimento`
--
ALTER TABLE `detalhe_atendimento`
  MODIFY `id_det_atendimento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `endereco`
--
ALTER TABLE `endereco`
  MODIFY `id_endereco` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `equipe`
--
ALTER TABLE `equipe`
  MODIFY `id_equipe` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `funcao`
--
ALTER TABLE `funcao`
  MODIFY `id_funcao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `id_funcionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `lampada`
--
ALTER TABLE `lampada`
  MODIFY `id_lampada` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `lampada_senso`
--
ALTER TABLE `lampada_senso`
  MODIFY `id_ls` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `material`
--
ALTER TABLE `material`
  MODIFY `id_material` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `os`
--
ALTER TABLE `os`
  MODIFY `id_os` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `os_simples`
--
ALTER TABLE `os_simples`
  MODIFY `id_os_simples` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `rota`
--
ALTER TABLE `rota`
  MODIFY `id_rota` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `rua`
--
ALTER TABLE `rua`
  MODIFY `id_rua` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `servico_feito`
--
ALTER TABLE `servico_feito`
  MODIFY `id_sf` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `servico_veiculo`
--
ALTER TABLE `servico_veiculo`
  MODIFY `id_sv` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `solicitacao`
--
ALTER TABLE `solicitacao`
  MODIFY `id_solicitacao` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tbl_estado`
--
ALTER TABLE `tbl_estado`
  MODIFY `id_estado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `veiculos`
--
ALTER TABLE `veiculos`
  MODIFY `id_veiculos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
