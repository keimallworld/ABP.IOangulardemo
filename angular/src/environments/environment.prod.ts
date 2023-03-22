import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TiisShop',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44366/',
    redirectUri: baseUrl,
    clientId: 'TiisShop_App',
    responseType: 'code',
    scope: 'offline_access TiisShop',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44397',
      rootNamespace: 'TiisShop',
    },
  },
} as Environment;
