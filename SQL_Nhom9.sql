﻿CREATE DATABASE HCG_NHOMSO9
GO
USE HCG_NHOMSO9
GO
CREATE TABLE SUKIEN(
	MaSK nvarchar(20) NOT NULL PRIMARY KEY,
	MoTa nvarchar(500) NOT NULL
)
GO
CREATE TABLE LUAT(
	MaLuat nvarchar(15) NOT NULL PRIMARY KEY,
	VeTrai nvarchar(150) NOT NULL,
	VePhai nvarchar(150) NOT NULL
)
GO
INSERT INTO SUKIEN VALUES('a1', N'Ăn không ngon')
INSERT INTO SUKIEN VALUES('a2', N'Ăn uống không tiêu')
INSERT INTO SUKIEN VALUES('b1', N'Bỏng rát vùng thượng vị')
INSERT INTO SUKIEN VALUES('b2', N'Bụng luôn căng cứng')
INSERT INTO SUKIEN VALUES('b3', N'Buồn nôn')
INSERT INTO SUKIEN VALUES('c1', N'Căng thẳng')
INSERT INTO SUKIEN VALUES('c2', N'Chán ăn')
INSERT INTO SUKIEN VALUES('c3', N'Choáng váng')
INSERT INTO SUKIEN VALUES('c4', N'Chướng bụng')
INSERT INTO SUKIEN VALUES('c5', N'Đang bị trào ngược dạ dày')
INSERT INTO SUKIEN VALUES('c6', N'Đang bị Chảy máu tiêu hóa')
INSERT INTO SUKIEN VALUES('d1', N'Da dẻ xanh xao')
INSERT INTO SUKIEN VALUES('d2', N'Đại tiện ra máu')
INSERT INTO SUKIEN VALUES('d3', N'Đau bụng')
INSERT INTO SUKIEN VALUES('d4', N'Đau bụng âm ỉ có chu kì')
INSERT INTO SUKIEN VALUES('d5', N'Đau bụng giữa')
INSERT INTO SUKIEN VALUES('d6', N'Đau bụng trước ăn')
INSERT INTO SUKIEN VALUES('d7', N'Đau bụng sau ăn')
INSERT INTO SUKIEN VALUES('d8', N'Đau bụng trên')
INSERT INTO SUKIEN VALUES('d9', N'Đau bụng từng cơn không chu kỳ')
INSERT INTO SUKIEN VALUES('d10', N'Đau sau xương ức')
INSERT INTO SUKIEN VALUES('d11', N'Đau thượng vị')
INSERT INTO SUKIEN VALUES('d12', N'Đau thượng vị có chu kì')
INSERT INTO SUKIEN VALUES('d13', N'Đau thượng vị khi đói')
INSERT INTO SUKIEN VALUES('d14', N'Đau thượng vị sau khi ăn')
INSERT INTO SUKIEN VALUES('d15', N'Đau vùng ức mũi')
INSERT INTO SUKIEN VALUES('d16', N'Đầy bụng')
INSERT INTO SUKIEN VALUES('d17', N'Đầy hơi')
INSERT INTO SUKIEN VALUES('d18', N'Đi ngoài phân đen')
INSERT INTO SUKIEN VALUES('d19', N'Đi tiểu ra máu')
INSERT INTO SUKIEN VALUES('d20', N'Đang đau dạ dày')
INSERT INTO SUKIEN VALUES('h1', N'Hoa mắt')
INSERT INTO SUKIEN VALUES('k1', N'Kém ăn')
INSERT INTO SUKIEN VALUES('k2', N'Khó chịu')
INSERT INTO SUKIEN VALUES('k3', N'Khó tiêu')
INSERT INTO SUKIEN VALUES('m1', N'Mất máu cấp')
INSERT INTO SUKIEN VALUES('m2', N'Mất ngủ')
INSERT INTO SUKIEN VALUES('m3', N'Mệt mỏi')
INSERT INTO SUKIEN VALUES('n1', N'Nôn mửa')
INSERT INTO SUKIEN VALUES('n2', N'Nôn ra máu đen')
INSERT INTO SUKIEN VALUES('n3', N'Nôn ra máu tươi')
INSERT INTO SUKIEN VALUES('n4', N'Nóng rát, cồn cào thực quản')
INSERT INTO SUKIEN VALUES('n5', N'Nóng rát, cồn cào vùng bụng')
INSERT INTO SUKIEN VALUES('n6', N'Đang Nhiễm vi khuẩn hp dạ dày')
INSERT INTO SUKIEN VALUES('o1', N'Ợ chua')
INSERT INTO SUKIEN VALUES('o2', N'Ợ hơi')
INSERT INTO SUKIEN VALUES('o3', N'Ợ rát')
INSERT INTO SUKIEN VALUES('r1', N'Rối loạn tiêu hóa')
INSERT INTO SUKIEN VALUES('s1', N'Sôi bụng')
INSERT INTO SUKIEN VALUES('s2', N'Sụt cân bất thường')
INSERT INTO SUKIEN VALUES('t1', N'Tiêu hóa kém')
INSERT INTO SUKIEN VALUES('t2', N'Toát mồ hôi')
INSERT INTO SUKIEN VALUES('t3', N'Tức ngực')
INSERT INTO SUKIEN VALUES('t4', N'Tụt huyết áp')
INSERT INTO SUKIEN VALUES('v1', N'Đang bị Viêm loét dạ dày - tá tràng')
INSERT INTO SUKIEN VALUES('x1', N'Đang vị Xuất huyết dạ dày')


INSERT INTO SUKIEN VALUES('kl1', N'Ung thư dạ dày')
INSERT INTO SUKIEN VALUES('kl2', N'Stress')
INSERT INTO SUKIEN VALUES('kl3', N'Đau dạ dày')
INSERT INTO SUKIEN VALUES('kl4', N'Đau dạ dày cấp độ nặng')
INSERT INTO SUKIEN VALUES('kl5', N'Đau dạ dày cấp ')
INSERT INTO SUKIEN VALUES('kl6', N'Trào ngược dạ dày')
INSERT INTO SUKIEN VALUES('kl7', N'Viêm loét dạ dày - tá tràng')
INSERT INTO SUKIEN VALUES('kl8', N'Viêm dạ dày')
INSERT INTO SUKIEN VALUES('kl9', N'Chảy máu tiêu hóa')
INSERT INTO SUKIEN VALUES('kl10', N'Xuất huyết dạ dày')
INSERT INTO SUKIEN VALUES('kl11', N'Nhiễm vi khuẩn hp dạ dày')


INSERT INTO LUAT VALUES('r1','o2^o1^b3','d17')
INSERT INTO LUAT VALUES('r2','b2^a1^a2','t1')
INSERT INTO LUAT VALUES('r3','d3^c1^m3','KL2')
INSERT INTO LUAT VALUES('r4','d5^a1^d17^k3^c4','kl3')
INSERT INTO LUAT VALUES('r5','k1^a1^d14^b1^b3','kl3')
INSERT INTO LUAT VALUES('r6','n3^n2^d2^c3^h1^t4^m1^x1','kl4')
INSERT INTO LUAT VALUES('r7','o2^o1^d11^d15^d10','kl3')
INSERT INTO LUAT VALUES('r8','d8^d7^d6^c1','kl3')
INSERT INTO LUAT VALUES('r9','d11^n5^b3^n1^o2^o1^d16^c4^s1^c2','kl5')
INSERT INTO LUAT VALUES('r10','t3^k2^d17^k3^n4','kl6')
INSERT INTO LUAT VALUES('r11','b3^n1','kl6')
INSERT INTO LUAT VALUES('r12','n6^d20','kl7')
INSERT INTO LUAT VALUES('r13','d11^n1^b3^a2^d16','kl8')
INSERT INTO LUAT VALUES('r14','d11^d16^c5^n1','kl8')
INSERT INTO LUAT VALUES('r15','o2^o1^o3^b3^k2','kl7')
INSERT INTO LUAT VALUES('r16','d3^b3^n1^s2^d2','kl7')
INSERT INTO LUAT VALUES('r17','d7^d4','kl7')
INSERT INTO LUAT VALUES('r18','d7^d6^d4','kl7')
INSERT INTO LUAT VALUES('r19','d13','kl7')
INSERT INTO LUAT VALUES('r20','d17^k3^a1^d1','kl7')
INSERT INTO LUAT VALUES('r21','d12','kl7')
INSERT INTO LUAT VALUES('r22','d12^d3^b3^m2^r1','kl7')
INSERT INTO LUAT VALUES('r23','k2^d8^d9','kl7')
INSERT INTO LUAT VALUES('r24','c3^h1^t4^n3','kl9')
INSERT INTO LUAT VALUES('r25','v1','kl10')
INSERT INTO LUAT VALUES('r26','d18^n3^c3','kl10')
INSERT INTO LUAT VALUES('r27','d8^d3^d2','kl10')
INSERT INTO LUAT VALUES('r28','d20','kl10')
INSERT INTO LUAT VALUES('r29','t2^c4^n1','kl10')
INSERT INTO LUAT VALUES('r30','d5^d3^d17^k3','kl11')
INSERT INTO LUAT VALUES('r31','u1^s2^t1','kl1')
INSERT INTO LUAT VALUES('r32','m3^a1^a2','kl1')
INSERT INTO LUAT VALUES('r33','n1^d18','kl1')
INSERT INTO LUAT VALUES('r34','c6^n3^d19^d18','kl1')
INSERT INTO LUAT VALUES('r35','d20^d2','kl1')
INSERT INTO LUAT VALUES('r36','d20^n3','kl1')
INSERT INTO LUAT VALUES('r37','v1^d18','kl1')
INSERT INTO LUAT VALUES('r38','v1^u1^b3','kl1')
INSERT INTO LUAT VALUES('r39','d9','kl1')
INSERT INTO LUAT VALUES('r40','d3^s2^n3^d2^o2^k3','kl1')

SELECT * FROM SUKIEN
SELECT * FROM LUAT





