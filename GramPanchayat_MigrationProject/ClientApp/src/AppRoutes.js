import { Home } from "./components/Home";
import { Login } from "./components/Login/Login";
import { PropertyTaxPaidForm } from "./components/Login/PropertyTaxPaid";
import MenuPage from "./components/MenuPage/MenuPage";
import { PropertyTaxPaid } from "./Configuration/Configuration";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/login',
    element: <Login />
  },
  {
    path: '/menu',
    element: <MenuPage />
  },
  {
    path : '/propertyTaxPaid',
    element : <PropertyTaxPaidForm />
  }
];

export default AppRoutes;
