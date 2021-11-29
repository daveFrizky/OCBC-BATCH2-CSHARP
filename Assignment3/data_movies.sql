use database movies;

CREATE TABLE `data_movies` (
  `id` int(11) PRIMARY KEY NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Genre` varchar(50) NOT NULL,
  `Duration` varchar(50) NOT NULL,
  `ReleaseDate` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `data_movies` (`id`, `Name`, `Genre`, `Duration`, `ReleaseDate`) VALUES
(1, 'Bad Boys for Life', 'Action/Comedy', '2 h 5 mins', '2020-01-23 00:00:00'),
(2, 'John Wick', 'Action/Thriller', '1 h 41 mins', '2014-10-24 00:00:00'),
(3, 'The Martian', 'Sci-fi/Drama', '2 h 31 mins', '2015-10-02 00:00:00'),
(4, 'How to Train Your Dragon: The Hidden World', 'Animation/Family', '1 h 45 mins', '2019-02-22 00:00:00');


ALTER TABLE `data_movies`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;