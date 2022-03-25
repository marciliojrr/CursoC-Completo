﻿using ExercicioDeFixacao.Entities;
using System;

namespace ExercicioDeFixacao.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 0; i < months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);

                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, months);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
