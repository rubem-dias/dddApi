using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Notifies
    {

        public Notifies()
        {
            Notifications = new List<Notifies>();
        }

        [NotMapped]
        public string PropName { get; set; }
        [NotMapped]
        public string Message { get; set; }
        [NotMapped]
        public List<Notifies> Notifications { get; set; }

        public bool CheckPropString(string value, string proprName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(proprName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Necessary field",
                    PropName = proprName,
                });
                return false;
            }
            return true;
        }

        public bool CheckPropInt(int value, string proprName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(proprName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Necessary field",
                    PropName = proprName,
                });
                return false;
            }
            return true;
        }

    }
}
