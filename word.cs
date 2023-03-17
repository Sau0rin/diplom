using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    internal class word
    {
        private FileInfo fileinfo;

        public word(string filename)
        {
            if(File.Exists(filename))
            {
                fileinfo = new FileInfo(filename);
            }
            else
            {
                throw new ArgumentException("Файл не существует");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        { Random random = new Random();
            Word.Application app = null;
            try
            {
                 app = new Word.Application();
                object file = fileinfo.FullName;
                object missing = Type.Missing;

                app.Documents.Open(file);
                foreach(var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    object wrap = Word.WdFindWrap.wdFindContinue;
                    object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing, MatchCase: false, MatchWholeWord: false, MatchWildcards: false, MatchSoundsLike: missing, MatchAllWordForms: false, Forward: true, Wrap: wrap, Format: false, ReplaceWith: missing, Replace: replace);
                }

                object newfilename = Path.Combine(fileinfo.DirectoryName, random.Next().ToString() + fileinfo.Name);

                app.ActiveDocument.SaveAs2(newfilename);
                app.ActiveDocument.Close();
                
                return true;
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }

            finally
            {
                if (app!=null)
                app.Quit();
            }
            return false;
        }
    }
}
