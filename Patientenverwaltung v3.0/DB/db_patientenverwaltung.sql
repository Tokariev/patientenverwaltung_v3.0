-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Мар 16 2019 г., 16:05
-- Версия сервера: 10.1.34-MariaDB
-- Версия PHP: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `db_patientenverwaltung`
--

-- --------------------------------------------------------

--
-- Структура таблицы `patienten`
--

CREATE TABLE `patienten` (
  `id_patient` int(11) NOT NULL,
  `sozialnr` int(11) NOT NULL,
  `name` varchar(255) COLLATE latin1_german1_ci DEFAULT NULL,
  `vorname` varchar(255) COLLATE latin1_german1_ci DEFAULT NULL,
  `geschlecht` varchar(255) COLLATE latin1_german1_ci DEFAULT NULL,
  `adresse` varchar(255) COLLATE latin1_german1_ci DEFAULT NULL,
  `geburtsdatum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Дамп данных таблицы `patienten`
--

INSERT INTO `patienten` (`id_patient`, `sozialnr`, `name`, `vorname`, `geschlecht`, `adresse`, `geburtsdatum`) VALUES
(1, 3456789, 'abc', 'def', 'ghi', 'straße', '2019-05-30'),
(14, 122222, 'Vorname', '123', NULL, NULL, NULL),
(19, 8888, 'Name', 'Vorname', NULL, NULL, NULL),
(20, 123333333, 'CCCC', 'BBBBBBBB', NULL, NULL, NULL),
(21, 222222333, 'sdsd', 'asdasd', NULL, NULL, NULL),
(22, 4535352, '', '', NULL, NULL, NULL),
(23, 326545636, 'asdfadf', 'adfafafa', NULL, NULL, NULL),
(25, 31234, 'qwerq', 'qwer', NULL, NULL, NULL),
(26, 23452354, 'rwrtw', 'wert', NULL, NULL, NULL),
(27, 12221111, '', '', NULL, NULL, NULL),
(28, 9090909, '1212121', '', NULL, NULL, NULL),
(29, 54321, 'Kolya', 'Mykola', NULL, NULL, NULL),
(30, 88888888, 'Marco', 'Schmidt', NULL, NULL, NULL),
(31, 221212, 'A', 'sss', NULL, NULL, NULL),
(32, 345261, 'qewr', 'qwer', NULL, NULL, NULL),
(33, 234523456, 'As', 'as', NULL, NULL, NULL),
(34, 52345, 'df', 'sdf', NULL, NULL, NULL),
(35, 34565, 'gsfg', 'sdfgs', NULL, NULL, NULL),
(36, 234, 'wer', 'qwer', NULL, NULL, NULL),
(37, 7689099, 'ghkchkg', 'fghkjfghk', NULL, NULL, NULL),
(38, 34535, 'werwrew', 'qwerqwe', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `termine`
--

CREATE TABLE `termine` (
  `id_termin` int(11) NOT NULL,
  `id_patient` int(11) NOT NULL,
  `datum` date NOT NULL,
  `uhrzeit_von` time NOT NULL,
  `uhrzeit_bis` time NOT NULL,
  `betreff` varchar(255) CHARACTER SET latin1 COLLATE latin1_german1_ci NOT NULL,
  `befund` varchar(255) CHARACTER SET latin1 COLLATE latin1_german1_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Дамп данных таблицы `termine`
--

INSERT INTO `termine` (`id_termin`, `id_patient`, `datum`, `uhrzeit_von`, `uhrzeit_bis`, `betreff`, `befund`) VALUES
(16, 14, '2019-03-12', '00:00:00', '00:00:00', '', NULL),
(21, 29, '2019-03-14', '10:00:00', '14:00:00', '', ''),
(22, 29, '2019-03-14', '10:00:00', '14:00:00', '', ''),
(23, 29, '2019-03-14', '10:00:00', '14:00:00', '', ''),
(28, 29, '2019-03-14', '00:00:11', '00:00:12', '', ''),
(29, 29, '2019-03-14', '04:00:00', '05:00:00', '', ''),
(30, 29, '2019-03-14', '00:00:00', '00:00:00', '', ''),
(31, 29, '2019-03-14', '00:00:00', '00:00:00', 'sdfasdf', 'asdfaf'),
(32, 28, '2019-03-14', '00:00:00', '00:00:00', 'Some Text', 'Some Text'),
(33, 28, '2019-03-14', '00:00:00', '00:00:00', 'Dann', 'Noch'),
(34, 34, '2019-03-16', '11:00:00', '12:00:00', 'Betetejydcny', ''),
(35, 35, '2019-03-16', '04:00:00', '05:00:00', 'aweaerwerqwerqwerqwer', ''),
(36, 36, '2019-03-16', '05:00:00', '05:00:00', 'asdfasdfasdfa', ''),
(38, 1, '2019-03-16', '10:00:00', '12:00:00', 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata', ''),
(39, 1, '2019-03-16', '12:00:00', '13:00:00', 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore ', ''),
(40, 34, '2019-03-16', '22:00:00', '23:00:00', '', 'Some '),
(41, 34, '2019-03-16', '05:00:00', '06:00:00', 'Lorem Ipsum für Designer, Schriftsetzer, Layouter, Grafikenthusiasten und alle anderen. Generiere einfach soviel Lorem Ipsum Text wie du brauchst, kopiere', '41'),
(42, 1, '2019-03-16', '08:00:00', '09:00:00', 'Lorem Ipsum für Designer, Schriftsetzer, Layouter, Grafikenthusiasten und alle anderen. Generiere einfach soviel Lorem Ipsum Text wie du brauchst, kopiere', ''),
(43, 35, '2019-03-16', '07:00:00', '09:00:00', 'Lorem Ipsum für Designer, Schriftsetzer, Layouter, Grafikenthusiasten und alle anderen. Generiere einfach soviel Lorem Ipsum Text wie du brauchst, kopiere', ''),
(44, 38, '2019-03-16', '00:00:11', '00:00:12', '', 'fertig');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `patienten`
--
ALTER TABLE `patienten`
  ADD PRIMARY KEY (`id_patient`);

--
-- Индексы таблицы `termine`
--
ALTER TABLE `termine`
  ADD PRIMARY KEY (`id_termin`),
  ADD KEY `FOREIGN_key` (`id_patient`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `patienten`
--
ALTER TABLE `patienten`
  MODIFY `id_patient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT для таблицы `termine`
--
ALTER TABLE `termine`
  MODIFY `id_termin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `termine`
--
ALTER TABLE `termine`
  ADD CONSTRAINT `termine_ibfk_1` FOREIGN KEY (`id_patient`) REFERENCES `patienten` (`id_patient`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
