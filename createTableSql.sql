--
-- Database: `inventoryMgmt`
--

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE orders (
  id int NOT NULL PRIMARY KEY,
  [user] varchar(100) NOT NULL,
  details varchar(5000) NOT NULL,
  price varchar(50) NOT NULL,
  paid varchar(30) NOT NULL DEFAULT 'no'
)

-- --------------------------------------------------------

--
-- Table structure for table `spareparts`
--

CREATE TABLE spareparts (
  id int NOT NULL PRIMARY KEY,
  model varchar(100) NOT NULL,
  part varchar(100) NOT NULL,
  type varchar(50) NOT NULL,
  price varchar(50) NOT NULL,
  instock int NOT NULL
)


--
-- Table structure for table `users`
--

CREATE TABLE users (
  id int NOT NULL PRIMARY KEY,
  first varchar(100) NOT NULL,
  last varchar(100) NOT NULL,
  username varchar(100) NOT NULL UNIQUE,
  phone varchar(10) NOT NULL,
  password varchar(50) NOT NULL,
  usertype varchar(20) NOT NULL DEFAULT 'member'
)