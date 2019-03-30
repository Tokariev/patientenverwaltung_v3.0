-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Мар 30 2019 г., 13:33
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
(40, 382585, 'Rita', 'Sack', 'w', 'Steinkamp 83', '2019-03-30'),
(41, 850905, 'Felicitas', 'Rohde', 'w', 'Willingrott 184', '2019-03-30'),
(42, 761482, 'Lars', 'Kronenberg', 'm', 'Sternstr. 187', '1949-01-07'),
(47, 987654, 'Monica', 'Belucci', 'w', 'Rona, Strada Principale 1', '2019-03-30');

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
(51, 40, '2019-03-22', '19:00:00', '20:00:00', 'Ein kleines Bächlein namens Duden fließt durch ihren Ort und versorgt sie mit den nötigen Regelialien. Es ist ein paradiesmatisches Land, in dem einem gebratene Satzteile in den Mund fliegen. Nicht einmal von der allmächtigen Interpunktion werden die Blin', NULL),
(52, 40, '2019-03-29', '20:46:00', '20:46:00', '', NULL),
(54, 41, '2019-03-29', '22:36:17', '22:36:17', 'Blablalbla', NULL),
(58, 39, '2019-03-29', '23:25:47', '23:25:47', 'asAS', 'A'),
(62, 39, '2019-03-29', '23:28:57', '23:28:57', 'gfasd', NULL),
(65, 39, '2019-03-29', '23:25:47', '23:25:47', 'fghjklö', 'ghjklö'),
(67, 47, '2019-03-30', '12:00:00', '14:00:00', 'Kopfschmerzen wegen Paparazzi', 'So what happens. When I run the win form and press the mentioned next button if none of the 4 radio buttons are selected, the form selects the 1st one. If any other radio button is selected the form deselects it, selects the first one and executes the \"..'),
(68, 47, '2019-03-30', '15:00:00', '16:00:00', 'Long story short part of my software is to have 4 radio buttons. I have to know if one of them is checked on some other button click.   1', 'So what happens. When I run the win form and press the mentioned next button if none of the 4 radio buttons are selected, the form selects the 1st one. If any other radio button is selected the form deselects it, selects the first one and executes the \"..');

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
  MODIFY `id_patient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT для таблицы `termine`
--
ALTER TABLE `termine`
  MODIFY `id_termin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=70;

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
