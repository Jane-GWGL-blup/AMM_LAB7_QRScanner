using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_QRScanner.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
