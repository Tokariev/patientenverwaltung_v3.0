-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Мар 21 2019 г., 11:39
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
(39, 176425, 'Joschua', 'Grieche', 'm', 'Dodostr. 167', '1937-04-03'),
(40, 382585, 'Rita', 'Sack', 'f', 'Steinkamp 83', '1954-04-03'),
(41, 850905, 'Felicitas', 'Rohde', 'f', 'Willingrott 184', '1987-08-07'),
(42, 761482, 'Lars', 'Kronenberg', 'm', 'Sternstr. 187', '1949-01-07');

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
(45, 42, '2019-02-23', '07:30:00', '08:30:00', 'Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et', 'Befund bezeichnet medizinisch relevante, körperliche oder psychische Erscheinungen, Gegebenheiten, Veränderungen und Zustände eines Patienten, die durch Fachpersonal (Ärzte, anderes medizinisches Personal) als Untersuchungsresultat erhoben werden. '),
(48, 42, '2019-03-21', '12:00:00', '13:00:00', 'Blindtext wird im Design als Platzhalter verwendet, wenn es noch keinen konkreten Text gibt, damit man sich den Flyer oder die neue Website besser vorstellen kann.', NULL),
(49, 42, '2019-03-21', '15:00:00', '16:00:00', 'Alles Käse? Auch hierfür gibt es einen Blindtext-Generator. Mit Mozzarella, Cheeseburger, Fondue, Camembert und mehr lässt sich ein zufälliger Blindtext mit »cheesy« Begriffen, Phrasen und Texten generieren.', NULL),
(50, 40, '2019-03-20', '18:00:00', '19:00:00', 'Weit hinten, hinter den Wortbergen, fern der Länder Vokalien und Konsonantien leben die Blindtexte. Abgeschieden wohnen Sie in Buchstabhausen an der Küste des Semantik, eines großen Sprachozeans.', NULL),
(51, 40, '2019-03-22', '19:00:00', '20:00:00', 'Ein kleines Bächlein namens Duden fließt durch ihren Ort und versorgt sie mit den nötigen Regelialien. Es ist ein paradiesmatisches Land, in dem einem gebratene Satzteile in den Mund fliegen. Nicht einmal von der allmächtigen Interpunktion werden die Blin', NULL);

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
  MODIFY `id_patient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT для таблицы `termine`
--
ALTER TABLE `termine`
  MODIFY `id_termin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

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
