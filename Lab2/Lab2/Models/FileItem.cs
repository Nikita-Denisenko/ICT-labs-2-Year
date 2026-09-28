namespace Lab2.Models
{
    public sealed class FileItem
    {
        public string Name { get; }
        public string FullPath { get; }
        public long Size { get; }
        public FileSizeCategory Category { get; }

        public FileItem(
            string name,
            string fullPath,
            long size,
            FileSizeCategory category)
        {
            Name = name;
            FullPath = fullPath;
            Size = size;
            Category = category;
        }
    }
}
