ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [FAD2_log], FILENAME = '$(DefaultLogPath)$(DatabaseName)2_1.ldf', MAXSIZE = 2097152 MB, FILEGROWTH = 10 %);

