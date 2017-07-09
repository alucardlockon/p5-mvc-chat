DROP TABLE IF EXISTS p5_chat;

CREATE TABLE p5_chat (
  id INT(11) PRIMARY KEY AUTO_INCREMENT,
  createtime DATETIME,
  author VARCHAR(20),
  msg VARCHAR(50),
  usrimg VARCHAR(20),
  ip VARCHAR(20)
)
  ENGINE=InnoDB
  DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
  AUTO_INCREMENT=1
  ROW_FORMAT=COMPACT;

INSERT INTO p5_chat(createtime, author, msg, usrimg, ip) VALUES ('2000-01-01','alucardlockon','ª∂”≠ π”√P5 Chat','joker.jpg','0.0.0.0');

SELECT * FROM p5_chat;