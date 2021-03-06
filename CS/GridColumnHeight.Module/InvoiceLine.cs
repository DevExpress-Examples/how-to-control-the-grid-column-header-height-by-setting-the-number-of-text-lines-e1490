﻿using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace GridColumnHeight.Module
{
    public class InvoiceLine : BaseObject
    {
        public InvoiceLine(Session session)
            : base(session)
        {

        }

        #region Header

        [Association()]
        [Persistent("Header")]
        private Invoice _header;

        [PersistentAlias("_header")]
        [MemberDesignTimeVisibility(false)]
        public Invoice Header
        {
            get
            {
                return _header;
            }
        }

        private void SetHeader(Invoice value)
        {
            SetPropertyValue<Invoice>("Header", ref _header, value);
        }
        
        #endregion

        #region DocumentNumber

        public string DocumentNumber
        {
            get
            {
                return Header == null ? string.Empty : Header.DocumentNumber;
            }
        }

        #endregion

        #region DocumentChaseDate

        public DateTime? DocumentChaseDate
        {
            get
            {
                return Header == null ? null : Header.DocumentChaseDate;
            }
        }

        #endregion

        #region SpaceWaster01

        private string _spaceWaster01;

        public string SpaceWaster01
        {
            get
            {
                return _spaceWaster01;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster01", ref _spaceWaster01, value);
            }
        }

        #endregion

        #region SpaceWaster02

        private string _spaceWaster02;

        public string SpaceWaster02
        {
            get
            {
                return _spaceWaster02;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster02", ref _spaceWaster02, value);
            }
        }

        #endregion

        #region SpaceWaster03

        private string _spaceWaster03;

        public string SpaceWaster03
        {
            get
            {
                return _spaceWaster03;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster03", ref _spaceWaster03, value);
            }
        }

        #endregion

        #region SpaceWaster04

        private string _spaceWaster04;

        public string SpaceWaster04
        {
            get
            {
                return _spaceWaster04;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster04", ref _spaceWaster04, value);
            }
        }

        #endregion

        #region SpaceWaster05

        private string _spaceWaster05;

        public string SpaceWaster05
        {
            get
            {
                return _spaceWaster05;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster05", ref _spaceWaster05, value);
            }
        }

        #endregion

        #region SpaceWaster06

        private string _spaceWaster06;

        public string SpaceWaster06
        {
            get
            {
                return _spaceWaster06;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster06", ref _spaceWaster06, value);
            }
        }

        #endregion

        #region SpaceWaster07

        private string _spaceWaster07;

        public string SpaceWaster07
        {
            get
            {
                return _spaceWaster07;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster07", ref _spaceWaster07, value);
            }
        }

        #endregion

        #region SpaceWaster08

        private string _spaceWaster08;

        public string SpaceWaster08
        {
            get
            {
                return _spaceWaster08;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster08", ref _spaceWaster08, value);
            }
        }

        #endregion

        #region SpaceWaster09

        private string _spaceWaster09;

        public string SpaceWaster09
        {
            get
            {
                return _spaceWaster09;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster09", ref _spaceWaster09, value);
            }
        }

        #endregion

        #region SpaceWaster10

        private string _spaceWaster10;

        public string SpaceWaster10
        {
            get
            {
                return _spaceWaster10;
            }
            set
            {
                SetPropertyValue<string>("SpaceWaster10", ref _spaceWaster10, value);
            }
        }

        #endregion
  
     
    }
}
