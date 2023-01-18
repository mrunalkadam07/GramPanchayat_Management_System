import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Home } from './components/Home';
import { Layout } from './components/Layout';
import { Login } from './components/Login/Login';
import './custom.css';
import './Login.css';
import './PropertyTaxPaid.css';
import {
  BrowserRouter as Router,
} from "react-router-dom";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Routes>
            {AppRoutes.map((route, index) => {
            const { element, ...rest } = route;
            return <Route key={index} {...rest} element={element} />;
          })} 
          </Routes>
      </Layout>
    );
  }
}
