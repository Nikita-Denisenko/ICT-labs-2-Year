using System.Text;

namespace Lab2.Services
{
    public sealed class TreeTextService
    {
        public string BuildText(TreeNode rootNode)
        {
            var builder = new StringBuilder();

            AppendNode(
                builder,
                rootNode,
                0);

            return builder.ToString();
        }

        private void AppendNode(
            StringBuilder builder,
            TreeNode node,
            int level)
        {
            builder.AppendLine(
                new string(' ', level * 4) + node.Text);

            foreach (TreeNode child in node.Nodes)
            {
                AppendNode(
                    builder,
                    child,
                    level + 1);
            }
        }
    }
}
