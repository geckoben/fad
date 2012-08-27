ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [FAD2], FILENAME = '$(DefaultDataPath)$(DatabaseName)2.mdf', FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

