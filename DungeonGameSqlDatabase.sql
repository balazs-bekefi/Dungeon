-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Gép: localhost:3306
-- Létrehozás ideje: 2022. Ápr 18. 13:27
-- Kiszolgáló verziója: 10.5.13-MariaDB
-- PHP verzió: 7.3.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `id18587062_epiz_31230115_test`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `playerdata`
--

CREATE TABLE `playerdata` (
  `ID` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `Health` int(11) NOT NULL DEFAULT 5,
  `Pesos` int(11) NOT NULL DEFAULT 0,
  `Experience` int(11) NOT NULL DEFAULT 0,
  `WeaponLevel` int(11) NOT NULL DEFAULT 0,
  `PlayedTime` varchar(20) NOT NULL DEFAULT '0',
  `LastScene` varchar(11) NOT NULL DEFAULT 'Main',
  `GameQuality` int(11) NOT NULL DEFAULT 0,
  `MusicVolume` varchar(20) NOT NULL DEFAULT '0,5000',
  `skinID` int(11) NOT NULL DEFAULT 0,
  `killedEnemy` int(11) NOT NULL DEFAULT 0,
  `deaths` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `playerdata`
--

INSERT INTO `playerdata` (`ID`, `UserId`, `Health`, `Pesos`, `Experience`, `WeaponLevel`, `PlayedTime`, `LastScene`, `GameQuality`, `MusicVolume`, `skinID`, `killedEnemy`, `deaths`) VALUES
(6, 6, 5, 0, 0, 0, '0', 'Main', 0, '0.5', 0, 0, 0),
(7, 7, 5, 0, 0, 0, '0', 'Main', 0, '0.5', 0, 0, 0),
(8, 8, 33, 85, 615, 6, '1844,8460', 'Dungeon5', 0, '0,8257', 2, 62, 2),
(9, 9, 5, 5, 0, 0, '15,2300', 'Main', 2, '0,2457', 0, 0, 0),
(10, 10, 4, 650, 0, 2, '66,3487', 'Dungeon1', 0, '0,6059', 0, 0, 0),
(11, 11, 14, 6086, 258, 6, '5375,6200', 'Main', 2, '0,3640', 3, 518, 1),
(12, 12, 9, 519, 390, 6, '594,8331', 'Main', 2, '0,3640', 3, 35, 2),
(13, 13, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(14, 14, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(15, 15, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(16, 16, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(17, 17, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(18, 18, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(19, 19, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(20, 20, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(21, 21, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(22, 22, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(23, 23, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(24, 24, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(25, 25, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(26, 26, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(27, 27, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(28, 28, 35, 1483, 3144, 6, '4602,3310', 'Main', 2, '0,2690', 2, 243, 3),
(29, 29, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(30, 30, 29, 57, 828, 6, '1296,6330', 'Dungeon5', 2, '0,4630', 0, 72, 2),
(31, 31, 43, 296, 1343, 6, '2656,1140', 'Dungeon4.5', 2, '0,2690', 0, 143, 11),
(32, 32, 9, 1709, 4084, 6, '9730.0000', 'Dungeon5', 0, '0.0000', 1, 313, 13),
(33, 33, 5, 0, 0, 0, '13,8149', 'Main', 2, '0,1744', 0, 0, 0),
(34, 34, 21, 82, 246, 4, '644,1843', 'Dungeon5', 0, '0,0000', 0, 31, 3),
(35, 35, 13, 47, 81, 3, '384,8611', 'Dungeon4.5', 2, '0,8424', 0, 12, 0),
(36, 36, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(37, 36, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(38, 37, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(39, 38, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(40, 39, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(41, 40, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(42, 40, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(43, 41, 43, 424, 1395, 6, '1539,1850', 'Dungeon5', 0, '1,0000', 3, 140, 10),
(44, 42, 23, 80, 299, 4, '1055,8840', 'Dungeon5', 0, '1,0000', 2, 27, 0),
(45, 43, 16, 705, 24, 0, '127.9547', 'Dungeon1', 0, '1.0000', 0, 2, 0),
(46, 43, 5, 0, 0, 0, '0', 'Main', 0, '0,5000', 0, 0, 0),
(47, 44, 13, 47, 81, 3, '213,5643', 'Dungeon4.5', 0, '1,0000', 0, 12, 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `created_at` datetime DEFAULT current_timestamp(),
  `salt` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `created_at`, `salt`) VALUES
(6, 'test11', '$5$rounds=5000$lockedpasstest11$tlwoS4aUp.bMCtLCRmLVPZmjjVtmo5Yri.AYdAwIVp2', '2022-03-04 22:30:02', '$5$rounds=5000$lockedpasstest11$'),
(7, 'dsadsa', '$5$rounds=5000$lockedpassdsadsa$N92zSdDTmvBExP8lznBheKG9aG3ieYX4XILwYMaUF91', '2022-03-05 09:07:24', '$5$rounds=5000$lockedpassdsadsa$'),
(8, 'asdasd', '$5$rounds=5000$lockedpassasdasd$Py2cd5B0g2qbTJCp1ogW7axH8i6aFzlB5DGRlBITqkC', '2022-03-06 12:02:13', '$5$rounds=5000$lockedpassasdasd$'),
(9, 'belabela', '$5$rounds=5000$lockedpassbelabe$3nUr5aDMoBw/W8AgYfW6iP3twWycxhhVqZvbbE15dVA', '2022-03-07 18:45:05', '$5$rounds=5000$lockedpassbelabela$'),
(10, 'ballazs', '$5$rounds=5000$lockedpassballaz$hccyU6U2aLfmjCImmIfRoFtT.PQlNQvwSa8fQzu9879', '2022-03-10 10:19:35', '$5$rounds=5000$lockedpassballazs$'),
(11, 'Geniusz', '$5$rounds=5000$lockedpassGenius$QYXIg2zS18ikNw9dhSxaHfdAjXZO9MXpzGRDt80iWj/', '2022-03-23 21:16:39', '$5$rounds=5000$lockedpassGeniusz$'),
(12, 'advilutlraforte', '$5$rounds=5000$lockedpassadvilu$C2/fQ9w0sFnpm9atJaCjmGfANm0DIXZP8ZZaNnxfpC5', '2022-03-23 22:10:43', '$5$rounds=5000$lockedpassadvilutlraforte$'),
(13, 'RandomUsername26205', '$5$rounds=5000$lockedpassRandom$KlvU0KSeC0z3E1M2sO1lT/phKxaR5n.3iOlx9QpqPw2', '2022-03-28 08:43:45', '$5$rounds=5000$lockedpassRandomUsername26205$'),
(14, 'RandomUsername39359', '$5$rounds=5000$lockedpassRandom$QXSPPM0srMgsYCCHmbOm.qbgHhhWeglI.1KtXjkg5XA', '2022-03-28 08:46:45', '$5$rounds=5000$lockedpassRandomUsername39359$'),
(15, 'RandomUsername79928', '$5$rounds=5000$lockedpassRandom$lBcgGZ8jdwGE9t4tCowepKPGPrCOLg41sLGKAcouNa6', '2022-03-28 08:48:55', '$5$rounds=5000$lockedpassRandomUsername79928$'),
(16, 'RandomUsername13588', '$5$rounds=5000$lockedpassRandom$LFY1D169x4wWMhSHKlanOYLv.ppaWji4INyUp8U0OU5', '2022-03-28 08:49:07', '$5$rounds=5000$lockedpassRandomUsername13588$'),
(17, 'RandomUsername16117', '$5$rounds=5000$lockedpassRandom$shJ3pDDh5C7IR1LGe2K/SI4ku/ZadrjJ834zX826K95', '2022-03-28 08:49:30', '$5$rounds=5000$lockedpassRandomUsername16117$'),
(18, 'RandomUsername64295', '$5$rounds=5000$lockedpassRandom$LcIq.zXKP1OcjHmLw0jOcdqhk9Mw3qsAiTCoQ.o9AvC', '2022-03-28 08:59:23', '$5$rounds=5000$lockedpassRandomUsername64295$'),
(19, 'RandomUsername98060', '$5$rounds=5000$lockedpassRandom$0KFULlM4L.dRsTWMJqo1cQ1.HHTfD0LK5ttSzsCCwY8', '2022-03-28 09:01:08', '$5$rounds=5000$lockedpassRandomUsername98060$'),
(20, 'RandomUsername75675', '$5$rounds=5000$lockedpassRandom$5KTOUh9AMlOZdHgVDL7achFt8IVaXN6ltvqEtUch5G2', '2022-03-28 09:02:13', '$5$rounds=5000$lockedpassRandomUsername75675$'),
(21, 'RandomUsername96029', '$5$rounds=5000$lockedpassRandom$Zkedz2.TfG4t4UOpr4nJHMa3mrWSfNynvw0Z6Mubpd9', '2022-03-28 09:04:18', '$5$rounds=5000$lockedpassRandomUsername96029$'),
(22, 'RandomUsername98383', '$5$rounds=5000$lockedpassRandom$3pTeAtGggdtdYqQ4bYtlYhBxwltUWXFupQKdpzy1CaA', '2022-03-28 09:04:49', '$5$rounds=5000$lockedpassRandomUsername98383$'),
(23, 'sanyithegame', '$5$rounds=5000$lockedpasssanyit$/b1vXB46ms7Z11Ei4LjyMIiVWsGz4g63XlF/RLjnuO3', '2022-03-28 09:13:24', '$5$rounds=5000$lockedpasssanyithegame$'),
(24, 'RandomUsername85188', '$5$rounds=5000$lockedpassRandom$wP/uaV0xHDaXiQOZRPGE6awHHU4GMuEdENuJbIivsLC', '2022-03-28 09:44:45', '$5$rounds=5000$lockedpassRandomUsername85188$'),
(25, 'RandomUsername63291', '$5$rounds=5000$lockedpassRandom$.g.lS/xd3jEUTMZarjYty1BOWcwZF7iisPtIAIis9z8', '2022-03-28 09:46:40', '$5$rounds=5000$lockedpassRandomUsername63291$'),
(26, 'adonyx', '$5$rounds=5000$lockedpassadonyx$LM0jzy8MdHbX1u32Acz76tXreJJkrj3k1JWeQCaBFm/', '2022-03-28 21:25:44', '$5$rounds=5000$lockedpassadonyx$'),
(27, 'RandomUsername72341', '$5$rounds=5000$lockedpassRandom$A6oLEYVcVKETMm.8PUxykIHHATf8GlN74kgh.w6Ktu1', '2022-03-30 08:12:02', '$5$rounds=5000$lockedpassRandomUsername72341$'),
(28, 'ElekZoli123', '$5$rounds=5000$lockedpassElekZo$XJDoxieM57URRVYKb8HepM93i4OH5z6q6PGbcY3Nje.', '2022-04-04 14:14:59', '$5$rounds=5000$lockedpassElekZoli123$'),
(29, 'asdasd1', '$5$rounds=5000$lockedpassasdasd$J84.ZGUBq0LxHfklioOdfQa0N4ZiaZ0a993RsTHHktD', '2022-04-04 15:28:42', '$5$rounds=5000$lockedpassasdasd1$'),
(30, 'asdasd2', '$5$rounds=5000$lockedpassasdasd$J84.ZGUBq0LxHfklioOdfQa0N4ZiaZ0a993RsTHHktD', '2022-04-04 15:31:01', '$5$rounds=5000$lockedpassasdasd2$'),
(31, 'DjFeri', '$5$rounds=5000$lockedpassDjFeri$OxknPjJOTDoyF2uoqRG4W3Gcov81VR75Ey8pXt6p975', '2022-04-04 15:51:09', '$5$rounds=5000$lockedpassDjFeri$'),
(32, 'kiraj1', '$5$rounds=5000$lockedpasskiraj1$a6wdjSwqEJamGUfXJA1F1AB2shvvlVhvRTLc1hQwFHD', '2022-04-04 18:53:47', '$5$rounds=5000$lockedpasskiraj1$'),
(33, 'asdasd3', '$5$rounds=5000$lockedpassasdasd$J84.ZGUBq0LxHfklioOdfQa0N4ZiaZ0a993RsTHHktD', '2022-04-05 10:51:29', '$5$rounds=5000$lockedpassasdasd3$'),
(34, 'asdasd4', '$5$rounds=5000$lockedpassasdasd$J84.ZGUBq0LxHfklioOdfQa0N4ZiaZ0a993RsTHHktD', '2022-04-05 16:15:58', '$5$rounds=5000$lockedpassasdasd4$'),
(35, 'Plaxo1', '$5$rounds=5000$lockedpassPlaxo1$U5S26dkTkiEr1hpVfbOz959OOpRsFeZF9V2sibHDnQ3', '2022-04-07 21:15:14', '$5$rounds=5000$lockedpassPlaxo1$'),
(36, 'asdasd6', '$5$rounds=5000$lockedpassasdasd$J84.ZGUBq0LxHfklioOdfQa0N4ZiaZ0a993RsTHHktD', '2022-04-08 09:02:48', '$5$rounds=5000$lockedpassasdasd6$'),
(37, 'RandomUsername98160', '$5$rounds=5000$lockedpassRandom$iZ5GYAeCEu8RVMU/ZcNes1.fScqwpBnPW6NoQJdXe18', '2022-04-11 09:25:35', '$5$rounds=5000$lockedpassRandomUsername98160$'),
(38, 'RandomUsername99720', '$5$rounds=5000$lockedpassRandom$YJohExwajmSpsOa5tWn4aXne3.8/qEFrY5AGg7CDsc8', '2022-04-11 09:30:28', '$5$rounds=5000$lockedpassRandomUsername99720$'),
(39, 'RandomUsername46234', '$5$rounds=5000$lockedpassRandom$NZxhcdeYXs93yhZQlhzz2z6e7RmH7X5NxDSsu0o7b.2', '2022-04-11 09:30:38', '$5$rounds=5000$lockedpassRandomUsername46234$'),
(40, 'RandomUsername40867', '$5$rounds=5000$lockedpassRandom$9zo/GbMs9wStMQGpPkcXoJf0BVZVIXTS0wLtFHDUsb6', '2022-04-11 09:42:01', '$5$rounds=5000$lockedpassRandomUsername40867$'),
(41, 'Bushi21', '$5$rounds=5000$lockedpassBushi2$VZNvRhz8GHv1QxUCTzRRWUc7y0T2qzMIO.SNgRg67/.', '2022-04-13 09:15:17', '$5$rounds=5000$lockedpassBushi21$'),
(42, 'K4lu69', '$5$rounds=5000$lockedpassK4lu69$6rPo0kkhS1JccQnKhE3tLliLBUFE/72hf1AKjlBn5L9', '2022-04-13 09:17:06', '$5$rounds=5000$lockedpassK4lu69$'),
(43, 'JoeBiden', '$5$rounds=5000$lockedpassJoeBid$cjf.60kSE2KMeiQlGXLO5jiESEhrugfccAFFfmN4hfA', '2022-04-14 07:44:44', '$5$rounds=5000$lockedpassJoeBiden$'),
(44, 'asdasd7', '$5$rounds=5000$lockedpassasdasd$J84.ZGUBq0LxHfklioOdfQa0N4ZiaZ0a993RsTHHktD', '2022-04-14 08:30:12', '$5$rounds=5000$lockedpassasdasd7$');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `playerdata`
--
ALTER TABLE `playerdata`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `playerdata`
--
ALTER TABLE `playerdata`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
