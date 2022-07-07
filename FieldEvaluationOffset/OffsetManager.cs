using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldEvaluationOffset
{
    public class OffsetManager
    {
        private List<Offset> listOfOffsets;
        private List<Offset> listOfMovedOffsets;

        public List<Offset> ListOfOffsets
        {
            get { return listOfOffsets; }
        }
        public List<Offset> ListOfMovedOffsets
        {
            get { return listOfMovedOffsets; }
        }
        public void addMovedOffset(Offset _offset)
        {
            Offset tempOffset = listOfMovedOffsets.FirstOrDefault(offset => offset.FieldID == _offset.FieldID);
            
            if (tempOffset == null)
            {
                Offset m_offset = new Offset(_offset);
                m_offset.ClearOffsetNumbers();
                listOfMovedOffsets.Add(m_offset);
            }
        }
        public void Add(Offset _offset)
        {
            listOfOffsets.Add(_offset);
        }
        public void Edit(Offset _offset, int index)
        {
            listOfOffsets[index] = _offset;
        }
        public void Delete(int index)
        {
            listOfOffsets.RemoveAt(index);
        }
        public void Clear()
        {
            listOfOffsets.Clear();
        }
        public OffsetManager()
        {
            listOfOffsets = new List<Offset>();
            listOfMovedOffsets = new List<Offset>();
        }
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index < listOfOffsets.Count)
                return true;
            else
                return false;
        }
        /*public bool CheckId()
        {
            bool ok = true;
            var query = listOfOffsets.GroupBy(x => x.FieldID)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();
            if (query.Count > 0)
            {
                ok = false;
                const string message = "Ett eller flera fält har lagts till mer än 1 gång, vill du fortsätta?";
                const string caption = "Form Closing";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);//window asking user yes or no to close form
                if (result == DialogResult.Yes)
                    ok = true;
            }
            return ok;
        }*/
    }
}
