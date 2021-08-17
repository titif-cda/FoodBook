using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
    public abstract class ViewModelBase :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Vérifie si une propriété correspond déjà à une valeur souhaitée. Définit la propriété et
        //   informe les auditeurs uniquement si nécessaire.
        /// </summary>
        /// <typeparam name="T">Type de la propriété.</typeparam>
        /// <param name="storage">Référence à une propriété avec getter et setter.</param>
        /// <param name="value">Valeur souhaitée pour la propriété. </param>
        /// <param name="propertyName">Nom de la propriété utilisée pour notifier les auditeurs. Ceci
        /// La valeur  est optionnelle et peut être fournie automatiquement lorsqu’elle est invoquée à partir de compilateurs qui
        /// support CallerMemberName.</param>
        /// <returns>True si la valeur a été modifiée, false si la valeur existante correspond à la
        /// valeur désirée</returns>
        protected bool Set<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
