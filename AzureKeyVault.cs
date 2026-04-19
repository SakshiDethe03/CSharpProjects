builder.Configuration.AddAzureKeyVault(
    new Uri(vaultUrl),
    new DefaultAzureCredential());