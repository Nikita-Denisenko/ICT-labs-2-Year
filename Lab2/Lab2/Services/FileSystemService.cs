using Lab2.Models;

namespace Lab2.Services
{
    public sealed class FileSystemService
    {
        private const long OneMegabyte = 1024 * 1024;
        private const long TenMegabytes = 10 * OneMegabyte;

        public FileSizeCategory GetCategory(long size)
        {
            if (size < OneMegabyte)
            {
                return FileSizeCategory.Small;
            }

            if (size <= TenMegabytes)
            {
                return FileSizeCategory.Medium;
            }

            return FileSizeCategory.Large;
        }

        public List<FileItem> GetFiles(string directoryPath)
        {
            var files = new List<FileItem>();

            try
            {
                foreach (string filePath in Directory.GetFiles(directoryPath))
                {
                    try
                    {
                        var fileInfo = new FileInfo(filePath);

                        files.Add(
                            new FileItem(
                                fileInfo.Name,
                                fileInfo.FullName,
                                fileInfo.Length,
                                GetCategory(fileInfo.Length)));
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }

            return files
                .OrderBy(file => file.Name)
                .ToList();
        }

        public List<string> GetDirectories(string directoryPath)
        {
            try
            {
                return Directory
                    .GetDirectories(directoryPath)
                    .OrderBy(path => path)
                    .ToList();
            }
            catch
            {
                return new List<string>();
            }
        }

        public long GetDirectorySize(string directoryPath)
        {
            long totalSize = 0;

            try
            {
                foreach (string filePath in Directory.GetFiles(directoryPath))
                {
                    try
                    {
                        totalSize += new FileInfo(filePath).Length;
                    }
                    catch
                    {
                    }
                }

                foreach (string directoryPathItem in
                         Directory.GetDirectories(directoryPath))
                {
                    totalSize += GetDirectorySize(directoryPathItem);
                }
            }
            catch
            {
            }

            return totalSize;
        }

        public string FormatSize(long size)
        {
            if (size < 1024)
            {
                return $"{size} Б";
            }

            if (size < 1024 * 1024)
            {
                return $"{size / 1024.0:F2} КБ";
            }

            if (size < 1024 * 1024 * 1024)
            {
                return $"{size / (1024.0 * 1024):F2} МБ";
            }

            return $"{size / (1024.0 * 1024 * 1024):F2} ГБ";
        }
    }
}
