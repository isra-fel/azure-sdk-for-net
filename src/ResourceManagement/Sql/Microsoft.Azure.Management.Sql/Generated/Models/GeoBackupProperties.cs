// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Database geo backup.
    /// </summary>
    public partial class GeoBackupProperties
    {
        private string _edition;
        
        /// <summary>
        /// Optional. Gets or sets edition
        /// </summary>
        public string Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }
        
        private string _elasticPoolName;
        
        /// <summary>
        /// Optional. Gets or sets the elastic pool name for the database
        /// </summary>
        public string ElasticPoolName
        {
            get { return this._elasticPoolName; }
            set { this._elasticPoolName = value; }
        }
        
        private DateTime _lastAvailableBackupDate;
        
        /// <summary>
        /// Optional. Gets or sets the last available backup date
        /// </summary>
        public DateTime LastAvailableBackupDate
        {
            get { return this._lastAvailableBackupDate; }
            set { this._lastAvailableBackupDate = value; }
        }
        
        private string _serviceLevelObjective;
        
        /// <summary>
        /// Optional. Gets or sets the current service level objective name for
        /// the database
        /// </summary>
        public string ServiceLevelObjective
        {
            get { return this._serviceLevelObjective; }
            set { this._serviceLevelObjective = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GeoBackupProperties class.
        /// </summary>
        public GeoBackupProperties()
        {
        }
    }
}
