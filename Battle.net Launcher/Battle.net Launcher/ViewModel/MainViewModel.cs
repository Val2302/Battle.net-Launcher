
using Battle.net_Launcher.View;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Battle.net_Launcher.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page Wow = new WowPage( );
        private Page Diablo = new DiabloPage( );
        private Page Hearthstone = new HearthstonePage( );
        private Page Overwatch = new OverwatchPage( );
        private Page StarCraft2 = new StarCraft2Page( );
        private Page StarCraft = new StarCraftPage( );
        private Page StormHeroes = new StormHeroesPage( );
        private Page Warcraft = new WarcraftPage( );

        private Page _currPage = new WowPage( );

        public Page CurrPage
        {
            get => _currPage;
            set => Set( ref _currPage, value );
        }

        public ICommand OpenWowPage
        {
            get => new RelayCommand( () => CurrPage = Wow);
        }

        public ICommand OpenDiabloPage
        {
            get => new RelayCommand( ( ) => CurrPage = Diablo );
        }

        public ICommand OpenHearthstonePage
        {
            get => new RelayCommand( ( ) => CurrPage = Hearthstone );
        }

        public ICommand OpenOverwatchPage
        {
            get => new RelayCommand( ( ) => CurrPage = Overwatch );
        }

        public ICommand OpenStarCraft2Page
        {
            get => new RelayCommand( ( ) => CurrPage = StarCraft2 );
        }

        public ICommand OpenStarCraftPage
        {
            get => new RelayCommand( ( ) => CurrPage = StarCraft );
        }

        public ICommand OpenStormHeroesPage
        {
            get => new RelayCommand( ( ) => CurrPage = StormHeroes );
        }

        public ICommand OpenWarcraftPage
        {
            get => new RelayCommand( ( ) => CurrPage = Warcraft );
        }
    }
}
