CONNECT HOTEL_PUBLIC/password@localhost:1521/HOTEL;
SET SERVEROUTPUT ON;

/*
    Check connection availability
*/
SET SERVEROUTPUT ON

DECLARE
  v_service_name VARCHAR2(100);
BEGIN
  SELECT SYS_CONTEXT('USERENV', 'SERVICE_NAME') INTO v_service_name FROM DUAL;
  DBMS_OUTPUT.PUT_LINE('Service Name: ' || v_service_name);
END;
/

/*
    các hàm thủ tục
*/

CREATE OR REPLACE A_insertEmployee(
    MANV         VARCHAR2,
    TENNV        VARCHAR2,
    PHAI         VARCHAR2,
    NGAYSINH     DATE,
    SODT         VARCHAR2,
    CCCD         VARCHAR2 ,  
    EMAIL        VARCHAR2,
    VAITRO       NVARCHAR2, 
    DIACHI       VARCHAR2,
    MATKHAU      VARCHAR2
)
IS

BEGIN
    INSERT INTO A_NHANVIEN VALUES(MANV, TENNV, PHAI, NGAYSINH,SODT ,CCCD,EMAIL, VAITRO ,DIACHI );
    CREATE USER MANV IDENTIFIED BY MATKHAU;
    GRANT HOTEL_EMP TO MANV;
EXCEPTION
    WHEN OTHERS THEN
        -- Handle the exception or log the error
        DBMS_OUTPUT.PUT_LINE('Error inserting NHANVIEN record: ' || SQLERRM);
        ROLLBACK;
END;